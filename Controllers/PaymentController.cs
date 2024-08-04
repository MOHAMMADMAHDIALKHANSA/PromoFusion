using MarketingHub.Data;
using MarketingHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class PaymentController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly StripeSettings _stripeSettings;
    private readonly UserManager<IdentityUser> _userManager;

    public PaymentController(ApplicationDbContext context, IOptions<StripeSettings> stripeSettings, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _stripeSettings = stripeSettings.Value;
        _userManager = userManager;
    }

    public IActionResult Index(int marketingAgencyId)
    {
        ViewBag.PublishableKey = _stripeSettings.PublishableKey;
        ViewBag.MarketingAgencyId = marketingAgencyId;
        return View();
    }

    [HttpPost]
    public IActionResult CreateSession([FromBody] PaymentRequest request)
    {
        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string> { "card" },
            LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(request.Amount * 100), // Amount in cents
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "Marketing Service"
                        }
                    },
                    Quantity = 1
                }
            },
            Mode = "payment",
            SuccessUrl = Url.Action("Success", "Payment", new { marketingAgencyId = request.MarketingAgencyId, amount = request.Amount }, Request.Scheme),
            CancelUrl = Url.Action("Cancel", "Payment", null, Request.Scheme)
        };

        var service = new SessionService();
        Session session = service.Create(options);

        return new JsonResult(new { id = session.Id });
    }

    public async Task<IActionResult> Success(int marketingAgencyId, decimal amount)
    {
        var userId = _userManager.GetUserId(User);
        var customer = await _context.Customers.SingleOrDefaultAsync(c => c.applicationUser.Id == userId);

        if (customer == null)
        {
            return NotFound("Customer not found.");
        }

        var payment = new Payment
        {
            CustomerId = customer.CustomerId,
            MarketingAgencyId = marketingAgencyId,
            Amount = amount,
            PaymentDate = DateTime.Now
        };

        _context.Payments.Add(payment);
        await _context.SaveChangesAsync();

        return View(payment);
    }

    public IActionResult Cancel()
    {
        return View();
    }
}

public class PaymentRequest
{
    public int MarketingAgencyId { get; set; }
    public decimal Amount { get; set; }
}
