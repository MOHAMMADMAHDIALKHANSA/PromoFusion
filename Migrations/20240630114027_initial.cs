using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ContractTypes",
                columns: table => new
                {
                    ContractTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTypes", x => x.ContractTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlRoute = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    AdministratorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.AdministratorId);
                    table.ForeignKey(
                        name: "FK_Administrators_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarketingAgency",
                columns: table => new
                {
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingAgency", x => x.MarketingAgencyId);
                    table.ForeignKey(
                        name: "FK_MarketingAgency_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarketingAgency_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customers_MarketingAgency_MarketingAgencyId",
                        column: x => x.MarketingAgencyId,
                        principalTable: "MarketingAgency",
                        principalColumn: "MarketingAgencyId");
                });

            migrationBuilder.CreateTable(
                name: "MarketingAgencyCategory",
                columns: table => new
                {
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingAgencyCategory", x => new { x.MarketingAgencyId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_MarketingAgencyCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarketingAgencyCategory_MarketingAgency_MarketingAgencyId",
                        column: x => x.MarketingAgencyId,
                        principalTable: "MarketingAgency",
                        principalColumn: "MarketingAgencyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarketingAgencyContractTypes",
                columns: table => new
                {
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: false),
                    ContractTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingAgencyContractTypes", x => new { x.MarketingAgencyId, x.ContractTypeId });
                    table.ForeignKey(
                        name: "FK_MarketingAgencyContractTypes_ContractTypes_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractTypes",
                        principalColumn: "ContractTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarketingAgencyContractTypes_MarketingAgency_MarketingAgencyId",
                        column: x => x.MarketingAgencyId,
                        principalTable: "MarketingAgency",
                        principalColumn: "MarketingAgencyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    picContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_MarketingAgency_MarketingAgencyId",
                        column: x => x.MarketingAgencyId,
                        principalTable: "MarketingAgency",
                        principalColumn: "MarketingAgencyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_MarketingAgency_MarketingAgencyId",
                        column: x => x.MarketingAgencyId,
                        principalTable: "MarketingAgency",
                        principalColumn: "MarketingAgencyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feedbacks_MarketingAgency_MarketingAgencyId",
                        column: x => x.MarketingAgencyId,
                        principalTable: "MarketingAgency",
                        principalColumn: "MarketingAgencyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proposals",
                columns: table => new
                {
                    ProposalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: false),
                    MinBudget = table.Column<double>(type: "float", nullable: false),
                    MaxBudget = table.Column<double>(type: "float", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RejectionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptanceNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ContractTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposals", x => x.ProposalId);
                    table.ForeignKey(
                        name: "FK_Proposals_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proposals_ContractTypes_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractTypes",
                        principalColumn: "ContractTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proposals_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proposals_MarketingAgency_MarketingAgencyId",
                        column: x => x.MarketingAgencyId,
                        principalTable: "MarketingAgency",
                        principalColumn: "MarketingAgencyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MarketingAgencyId = table.Column<int>(type: "int", nullable: false),
                    ReportDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefutationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefutedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Reports_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_MarketingAgency_MarketingAgencyId",
                        column: x => x.MarketingAgencyId,
                        principalTable: "MarketingAgency",
                        principalColumn: "MarketingAgencyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    UserReview = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "65d6c2dd-d38a-49a7-bd71-b0d4a8de1aa5", "ApplicationUser", "beyondfood@gmail.com", true, false, null, "foodcouple", "BEYONDFOOD@GMAIL.COM", "BEYONDFOOD@GMAIL.COM", "AQAAAAIAAYagAAAAEIfIQtf+YMEL20j14PmwK/hyIbWTozT6I5uzapIpRtGMrQ319wumoRQ04vCPMT5Tgw==", null, false, "0a939e45-67ea-49bc-bca1-b83388321788", false, "beyondfood@gmail.com" },
                    { "10", 0, "1d56dc05-18c2-4fe7-8d56-b9206af57453", "ApplicationUser", "gamingenthusiast@gmail.com", true, false, null, "Gaming Enthusiast", "GAMINGENTHUSIAST@GMAIL.COM", "GAMINGENTHUSIAST@GMAIL.COM", "AQAAAAIAAYagAAAAEBxfQLhMq4O46ujtW0OtmpB8DZxbPCv2Vml0Y/Gdzd03nWuhhV2pkzrpspkTd8pgpw==", null, false, "5327db33-f374-4c9d-afe8-879c98cbbb7b", false, "gamingenthusiast@gmail.com" },
                    { "11", 0, "05670685-1c30-4c50-b0e7-b4eaeb7cf357", "ApplicationUser", "mohammadmahdi@gmail.com", true, false, null, "Mohammad Mahdi", "MOHAMADMAHDI@GMAIL.COM", "MOHAMMAD MAHDI", "AQAAAAIAAYagAAAAEPqef3hFC34sENGS2BoO00rph1QuJ/km3JX0LVVD/C1PikxpnFYZ69lfqH+FC9OM1A==", null, false, "ebde7be0-9d9e-4e78-8381-7db389674ccb", false, "Mohammad Mahdi ALkhansa" },
                    { "2", 0, "6c24dd52-63e8-4861-b08a-47305a49d5fd", "ApplicationUser", "explorernico@gmail.com", true, false, null, "explorernico", "EXPLORERNICO@GMAIL.COM", "EXPLORERNICO@GMAIL.COM", "AQAAAAIAAYagAAAAEHABv4phwCjJYxWOJqAMDtcY68JD1/9dRIL2QF7+QA9rWzWLCqzxwsvVQXXTWFBpBg==", null, false, "73cbf248-fde8-4303-888e-e34fff67810f", false, "explorernico@gmail.com" },
                    { "3", 0, "36844f7a-33f4-47c3-be07-441287056938", "ApplicationUser", "evolve@gmail.com", true, false, null, "evolve", "EVOLVE@GMAIL.COM", "EVOLVE@GMAIL.COM", "AQAAAAIAAYagAAAAEO41rSJUrxU7Wzjjl2NuU7bBe3vFrIZ7JHuZSYRZ6w71e6pXcHo9ZbQ7psPH2dVNxg==", null, false, "120a88d6-976c-4741-8ba4-fadd46c148d8", false, "evolve@gmail.com" },
                    { "4", 0, "52fd8b5e-1c80-4fd6-b28f-565e5c413d76", "ApplicationUser", "foodcouple@gmail.com", true, false, null, "foodcouple", "FOODCOUPLE@GMAIL.COM", "FOODCOUPLE@GMAIL.COM", "AQAAAAIAAYagAAAAEPEQ0J7zFZ8iJO1LL29vELbmqEyO4xH6zvzweNLgYBW/pt7WqToru6rwE8eBJOq1wQ==", null, false, "4ccae42e-2519-41ee-a4f0-9390ab29c19b", false, "foodcouple@gmail.com" },
                    { "5", 0, "06aa4666-15ef-451a-8ff5-1f974ad52523", "ApplicationUser", "socialmediaqueen@gmail.com", true, false, null, "Social Media Queen", "SOCIALMEDIAQUEEN@GMAIL.COM", "SOCIALMEDIAQUEEN@GMAIL.COM", "AQAAAAIAAYagAAAAEFiTLk8QzEjhFAZbeRcWFp+DCu6gZwe4y6qCCv/s3INPz5zHVGRjRrrctAVIVu1NnQ==", null, false, "61c125ef-6664-4e31-adff-bab3cb081772", false, "socialmediaqueen@gmail.com" },
                    { "6", 0, "4b5a2469-47c5-470a-b132-a4a5800a99db", "ApplicationUser", "techtrendsetter@gmail.com", true, false, null, "Tech Trendsetter", "TECHTRENDSETTER@GMAIL.COM", "TECHTRENDSETTER@GMAIL.COM", "AQAAAAIAAYagAAAAEG6LMiFt+ZtYR3uEJRBME7AfiMKV5uEPs5V8Arcoh0pRWiO6cb6JeRyCWYLEyA4kdQ==", null, false, "f54398c6-9800-4f41-9591-0873f214009b", false, "techtrendsetter@gmail.com" },
                    { "7", 0, "f1f04674-935c-46a2-9c84-f79ffe516dd2", "ApplicationUser", "fitnessfreak@gmail.com", true, false, null, "Fitness Freak", "FITNESSFREAK@GMAIL.COM", "FITNESSFREAK@GMAIL.COM", "AQAAAAIAAYagAAAAEG3/Q/s+bUXLfL7qYuZLhVhkzXLSWyiQTnbJLuw0TPxrwxu9Sy6b4K4UzaP81z2L2g==", null, false, "33ed3dba-a198-4596-b9b7-699455085633", false, "fitnessfreak@gmail.com" },
                    { "8", 0, "98feed64-3e4a-4d91-8eed-b2389f52f6fe", "ApplicationUser", "traveljunkie@gmail.com", true, false, null, "Travel Junkie", "TRAVELJUNKIE@GMAIL.COM", "TRAVELJUNKIE@GMAIL.COM", "AQAAAAIAAYagAAAAEDaAJF+ntdSFcSwyKn49XN7Yjnzv2/WXtnFMVKYQR+vDpsI94UAGfxmz9Vz+8fv5lg==", null, false, "b1d29f7f-dbbb-408e-8d36-82305d7c84f4", false, "traveljunkie@gmail.com" },
                    { "9", 0, "076bdc09-9cb2-454f-9851-39996c05c62e", "ApplicationUser", "styleguru@gmail.com", true, false, null, "Style Guru", "STYLEGURU@GMAIL.COM", "STYLEGURU@GMAIL.COM", "AQAAAAIAAYagAAAAEBSHoOZ2sB0479m0FRGYIjFGZIhcuPXfPAUOb7CqjuKk7eW4ieXxQiIm0PhCvdysMQ==", null, false, "3bcdaa1c-eb5b-44dc-b990-db9fbe59de28", false, "styleguru@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Digital Media" },
                    { 2, "Video Promotion" },
                    { 3, "Image" },
                    { 4, "Audio" }
                });

            migrationBuilder.InsertData(
                table: "ContractTypes",
                columns: new[] { "ContractTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Full Implementation" },
                    { 2, "Material" },
                    { 3, "Strategy" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "BuildingName", "City", "ImageUrl", "PostalCode", "Region", "UrlRoute" },
                values: new object[,]
                {
                    { 2, "NASCOD", "Beirut", "https://www.yelleb.com/img/lb/j/1543234930-75-nascode.jpg", 51, "Sin El Fil", "https://maps.app.goo.gl/XdgeL5jJim1GpW997" },
                    { 3, "Samwoh", "Beirut", "https://www.samwoh.com.sg/images/Home_Page/5-Latest-Event.jpg", 51, "Horch Tabet", "https://maps.app.goo.gl/Pcjhs18qevw8UhAc7" },
                    { 4, "Born Creative", "Beirut", "https://thingsthatmatter.me/wp-content/uploads/2017/06/office.png", 51, "Horsh Tabet", "https://maps.app.goo.gl/Q6Vpxm7iRvT2cVuJ7" },
                    { 5, "IDS ", "Beirut", "https://www.macentreprise.com/img/projects/general-contracting/MHM%20Business%20Center%20-%20Antelias%20and%20Achrafieh%20-%20Adlieh/IMG_5730.jpg", 51, "Jnah", "https://g.co/kgs/4xKBRqp" },
                    { 7, "Hamra Tower", "Beirut", "https://images.unsplash.com/photo-1506748686214-e9df14d4d9d0", 51, "Hamra", "https://goo.gl/maps/Zk9rT2PvVtF2" },
                    { 8, "ABC Mall", "Beirut", "https://images.unsplash.com/photo-1574164575883-716f2c63d58b", 51, "Achrafieh", "https://goo.gl/maps/j6BzY3JgHkR2" },
                    { 9, "Beirut Souks", "Beirut", "https://images.unsplash.com/photo-1564866657312-25ea38246e1c", 51, "Downtown", "https://goo.gl/maps/X7dK1mF7VbN2" },
                    { 10, "Dunes Center", "Beirut", "https://images.unsplash.com/photo-1601600589881-2b5d3c4c2a3e", 51, "Verdun", "https://goo.gl/maps/H2bY1cP2YyF3" },
                    { 11, "Jal El Dib Tower", "Beirut", "https://images.unsplash.com/photo-1600490377848-c3f2f2b6b6a6", 51, "Jal El Dib", "https://goo.gl/maps/Jk3L6M8YzM4" },
                    { 12, "Gemmayze Plaza", "Beirut", "https://images.unsplash.com/photo-1600585154305-17f18f2c5c4a", 51, "Gemmayze", "https://goo.gl/maps/Fb8Z2hH7bNj2" }
                });

            migrationBuilder.InsertData(
                table: "MarketingAgency",
                columns: new[] { "MarketingAgencyId", "Description", "Email", "Facebook", "ImageUrl", "Instagram", "LinkedIn", "LocationId", "PhoneNumber", "Rating", "Salary", "Twitter", "UserId", "Username" },
                values: new object[,]
                {
                    { 1, "Our main objective is to leverage...", "BeyondFood@gmail.com", null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqBzemu65d0_r5XLDHA2yTwDMz_LZ_VdlsyAPozbIVVA&s", "https://www.instagram.com/beyondfood.lb?igsh=MXdkYWRoOGZ5Nm41Mw==", null, 2, "987654", 4.0, "150$", null, "1", "BeyonFood" },
                    { 2, "Catering to the diverse needs...", "Explorernico@gmail.com", null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1314X2xOaOYisxpppju84_U0mxInsp_3rYMX5KYjs2Tuk9m9xuvL7pUS_nal3vG7YZ8A&usqp=CAU", "https://www.instagram.com/explorernico?igsh=MXd1cWRkMnN2bWtuNw==", null, 3, "123456", 5.0, "225$", null, "2", "Explorernico" },
                    { 3, "Driven by a relentless pursuit...", "Evolve@gmail.com", null, "https://media.licdn.com/dms/image/C560BAQGRK1Kf6VCE8A/company-logo_200_200/0/1678115779285/evolvebst_logo?e=2147483647&v=beta&t=zytDG9Btn9NVSL_LZ1UL67zOASMjHvW8sGiY8nmQmOg", "https://www.instagram.com/evolve.pd?igsh=ZGV0ZDVzdTFxNm16", null, 4, "741258", 5.0, "300$", null, "3", "Evolve" },
                    { 4, "We're dedicated to elevating brands...", "FoodCouple@gmail.com", null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT0bf9-VN81pZVNblRCFeLHWXo9IlZYxheinxmXtJ9k5X06olNmg5uXgnsZMHHCkd7LScU&usqp=CAU", "https://www.instagram.com/foodcouplelb?igsh=bGdqYW5qam5ocW9n", null, 5, "852366", 5.0, "200$", null, "4", "Food Couple" },
                    { 5, "Expert in social media marketing and content creation. We help brands engage their audience with compelling content.", "socialmediaqueen@gmail.com", "https://www.facebook.com/socialmediaqueen", "data:image/png;base64,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", "https://www.instagram.com/socialmediaqueen", "https://www.linkedin.com/in/socialmediaqueen", 7, "9876543210", 5.0, "180$", "https://twitter.com/socialqueen", "5", "Social Media Queen" },
                    { 6, "Stay ahead in tech with our latest reviews and gadget launches. We bring the future of technology to you.", "techtrendsetter@gmail.com", "https://www.facebook.com/techtrendsetter", "data:image/jpeg;base64,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", "https://www.instagram.com/techtrendsetter", "https://www.linkedin.com/in/techtrendsetter", 8, "1234567890", 5.0, "200$", "https://twitter.com/techtrendset", "6", "Tech Trendsetter" },
                    { 7, "Join us on a journey to health and wellness with tailored fitness programs and healthy lifestyle tips.", "fitnessfreak@gmail.com", "https://www.facebook.com/fitnessfreak", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAA8FBMVEUAAAD/zAAAAAP/zgD8zAD/0QD/0w8AAQCFbyH3zBoLAAiCaw0tJQ+AbBn7zxX/0hb40CvnvyMKAgAuJgbBnxa0lxsnHwVLOwmqjRwNBgDetx4hFgLMqRTowBmagiXUsB1oVgZ1Yw5COA88LwhXShfjvSYfEQA+LgBiUg0rHwAdFAD70iGbgRcYEABVRA+3myRoVhtXRwFZTRtJOAqPdBgXCQAVBgdVQwjTtDDoxjuxmDH30jWmiyzuyjL80CnGpzScfwt1Xgc5LgC/pBRjSgbftQ3/2xQeGgWujxNSRRqPdRDTrBChggkzJATYuxvIoxiJ7Rh4AAAMzUlEQVR4nO2bC1fayhbHJ/NKU44JYBB5REB8oIjYKvU8e6rcWo/V+v2/zd3zSAghUUrh9K679m91IUkmk/lnz+y9Z4YSgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiAIgiDIa1AFoT+7GZvEJUrmz27FBqHJx/8pLrncrV1Vf6LEk62rOqHupqqnZOAxGYSZk1ncgu9rsP6gHMhhaWPjxKWkKThn8noz9c8eVHilIzkX5f4mBKqO4dJJxBzGg610a+ae5hJK5n3t/GVzbf6e2dhOmSZ7bGh4nHPnzhjRfeFNfC9uHCWOPOY4XO7NGkJp423ChNDq27cNWv0wO/f2gyry4a1qE6XVCRQiZJS6PjF197u93nWsCT6Pe1s3x9l+ve07gDjT7YF2rXM8Nra34XFHUUYhtODXcsJvp+T38sdfydbsVPnjHwfkz/LHck8Xr//x8a9fCJyYXf9byeo2h1Le+ZWHqn5t5OrbUArpN3vzrdj2WayQTNY5Gl1yfuh50z6ZZBRSNTSh41q8CbmXTodcCThwuKMvBO/IruAsgga5tO4zDxQ+Cie+STzDW7oKmCOYEEy2lXnIruRCCsa53M0o5EYhOWtGYX99EimpQJtFpTpSCp15GzZBWWT4rUVqgnVITx9xFqg/f52DQqZfPNgwcLwdAidkfE80JvTYZzKq3YdRAJJgxA8kl5/VMRNyi6Zig1EoS+RMQnu8y/UZ8VpqZRfVXIXyE2kYiFFYncDXG+l4x1V9cleAxbx+WiGUsvc0KLSXN1tQ1eReimhESchEqIZrq8NYMz0UE4WqHYKFCw1dma5UI1y+IZUchYKZka9Hv1ZI1XFPKlH65C70WUeGcD5RCH05uYeMmXKP0OP7h9Fv+6rHBAOd/l5E0bf0cIsVtrTHY3+tT+GN5C8olGfxQaIQ6Enu2cAFCsOmCqM0Vsh4J6nBJWPB2lUdZUaj04buFvemutGolW5HrPAXpdBxovUpLL1kQ+hSg8Gg2+1eNKxCLVErNCFrV7LxeaCkJzbkXs3wO9xUAsfi1Ur1kQ2B9zAOo1rvtroYLVIKOav8WwodaSiPFhUS5Yl3mRiTKXiNpJeq1ERIKYQoVyFefmMCKvGjsDdRpryNwNeqYDHuzrdj7QrdON94cRwyDn5eER3lKlQmA4WXnoiqiUIngHgHIkUZMgL6FHpSRRioo6u6bb0N4RGikJDN83SaPaeQ6QhEyA8k4mro1w6b4EdeVOg4zdpY8fuIFChUNlQh4uzWt+PQqXQNF1Wdyd2WahU/gLjp1ZWfIvWHaeSrkAC+ddHTWIUVSnd2p7v91VN62mpKSLTPXrFh4mlIkUJlQ0hqHe8/VqFkM0+TfPR7bbDtLtH5HSXVy61m4Mh0EpxVSKrfYMhCXFxRoatcAPRBbzR4yZcylWPE+XaxDbVD+cxn8dAkljASGu8HF19MI0Mh2mR0MbgYmTjSESKd1Swo3FINE+Hq07JPynbM33+XsiHLV2gpVqgTPGYVspkNCZlUxJ3OeCh5lGxKdnwhu+Z4KtIdZFEhPA6+NFdNUV1INkCQExykFWYzb1D4aTmF9DrgicLK+YHllNSgaOkIpN54XD4Q5byi7oRURw8+lwc5OU2iMFTtYp9XdzZn4LU598/fmazNKGTsTbpMsQ3ZvEI4GwqeRItA4Qd+uU4uh4yrRNWDuBi1wHUHcBzpY9nJy9pSClV+HzWou2I/1QpZcHCdGofw8C0VyKn9BzlNaqjUpIhzmjuR5DRSjvWXvieYUShiWFAnZBBJGO9Qt6z0VY8reZLp6CHbX5KqaTYeClCoeykoTLfaHLjkdRere6lWWA8yClO1jdud1PFeu71rah502tNtU82bdnvPFN5qt6eg8Ko9Y6oMfXLWiYZe1Hk4Vb2Zkv3HZtkbRu1eda6VmYh/mK/we4gVHvtFCvNek3arrvmWjA/9Ss1Rxi1Q15w5OvpgwoQSSUi1daQv0sJe6jS/R6FroxAlScYPZz7pCnIU2gK6OJlbOspfEU+aaRdqcovQmRgj2iwOpR6VsWFKYVIq+bPQDEpaitNRoxpDqLIhy7Xhly+jiSo5Gi3z9l6/WljGtqu1c9KvvqCwcXraSO7Rrc+6VzqqxZPuiiXaIg9FCs88WzCK3pDNMrXN8rx2qpc6cwrJfhOa04xR7ersZIxIt/WUi6UAp1how0MeF+XTzQqs+lx5VfXc4QkoZLkKS5JluHuXrckoTAMVnIkihSIuzcZrFeSSVI9VVvigRSl48GRWExd6acVO79KNl4MChbY2HVCbEL+NwrpKRtIKK4zZwmK9Cheo+nGjlcIgdxzmKOQLCmmODb9CBY72pUnEj6zCJrdl+PxykO37+WlivkufWcwldLHkKeQ3ttH+Sd/kVosKH5ZROOR2YDE9oYVpbZuE2lLBP0leGivsiHgYyngcxgtLlNB01JlbqU/HInsm5daT8+kX1L/z7bP4sLWfb8NIrS6KuWHI7xYUjmqxD222289Ap9OLbbiocE97UuW3Dm34t1sScRvd+ICmBCzYb+4FkFiuybdi244PrXusjEmhwvNmJUN7O/M4aJGNgh9SZ2vGhnZuIRKFlOiwae1gGbVmQIBKvtvLjZ3U9VjGaHadjHZaI1PbqHV0EuejtnoTnwsUfrYF0iw53bi3nmaQHYd5dGQQM7yl9WF84LWvVTt7d8nloGwXWFplKNuzeXwo70LdU7vDQP7xT94jMgo7dhg1SdEgX1bh+VIK22odmms8UBjobzqw+mo+C/NFNVTMddtlewGcatv71Uq3UjjwOCtf57Z4TqG6c6ZwRb7Lhm3GvEPDr31S9zmP1PdIchadgBrB/Up83b7ythrngc0+jEJyPmQsOqa5edxMoY74P6yQGoXOsjYU4n52BArlufoyupd6OQls6CdjXAd2euIpm8urlEJyGTEGk+L86V3KhqohSiE3qxirdVNXK4QaL7vLKWSpqXDdd+R77Sx3PL0fBnN+v5GKICDhIWBfH2W8DRAyiK1PkRDl26LWWoU3s3FoPc3Ka22PWqG/vZxCJhYVgsZGxNTii1I4VzslHcbOrgPHuyRGoahNvkEXrdOizV2rsGsVflNv5UdmwHrbC2rwaC8bD/MKgw3bNyXFVkMrDIw/LPl8eK49TfD8HKpQG+5rhbc+9/dJxKVeaFP2+PoVXsMxKVx12Q+ctEJIK3UvrayskF4PVYoTzu1bFNmQtgUXgdq/EMMnPQ7513Aahh2f39W0L43TJXF3rRU+SOUjaoFoWoXgeiH6DorXBjM2hKlBoNb+pypBWGm1jcJIkcyrL63QbmDECvXGNcSHBxV+VS/1g8AHhufE7Aco6w2GPNDdFPwiVMB49ESLJO4HbF7hdgQPGOaHliVQmfB5rXZN6TIKVS/9XKuFYS0ct4zCAHIAKTnvqB13pfDi/cXFxcHBhU5YzgMHeiQhkQPj11U7v5x594HgnULH0fczvZTchpXnhZngCiypcN7TcPmg9hUffSafTS/1q+nyuxA+1A5ixNlhlSqFzBuQ54DPLXPPYef43WQlSvNju/kmF15WYRwPXeNpDnQSBi2Pjoja9fYnyeyBKNuZXg2mkwNKbcTfjjj3F2avuQr1/mFhj14aPYCXUEgXIr6OFq5esCu3Fm14IJVjgiQVPJC+0eY0XbXwfbqEQrtDGi83/pjQko4ar9uwllWovZVg3rb+5YLfHVi21fq/qFxoICx61diGlNQkK9pNyvTSNe5yd19XSGlWIQeFqgcohU9aoXU9wBtyBHnAo4kLW5DWDWKFMFOtqEwuNy8FhTxrw/XwNNQrw8cv99J4d8IoDIRVeCNF8E7lNILFmxXyBs6yQP+OjdInT8hQxUNpZk/1IYTU3AhgFZZs5vG8NoFU/wZJgoVe6qVn4XNq7XR/HIYmp9n/Owz3YNw9hzMuyF74nLyPP8NwfKrO7JnOeQUl/sx7hFprY/o3UXfgn4ZFDmkliYPnaQle70sRP/mYnUplX9k1hYWb3OSj2HP0TcQvwUvoNGFivb7fJtJ4EeYlhWqHwZ2/iaQ3E9LLanDGTfy8/XGnG99A5tan0uzbtbYf/Q3GAq5N+pRCnvkF7UzQ3G9a5x++uDeRTiPd5JI7vxq8wL7KbbUNX9ntWBF46KFahSgYh/8C24EjuLbhZuqHXlGTapWlvpn6l6AJ2T0b1jf3S3ba6kg5LG2o/tehAw+ef7XJ/9NCq91SfVN9ZInHk/rupw33IOP1NvuMYoy73ewLptRd5/8C+E5c/fyf9ngEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQRAEQf6X+C9tNh2mA0vDHAAAAABJRU5ErkJggg==", "https://www.instagram.com/fitnessfreak", "https://www.linkedin.com/in/fitnessfreak", 9, "1122334455", 5.0, "150$", "https://twitter.com/fitness_freak", "7", "Fitness Freak" },
                    { 8, "Discover new destinations and travel tips from our seasoned experts who live to explore the world.", "traveljunkie@gmail.com", "https://www.facebook.com/traveljunkie", "https://images.unsplash.com/photo-1506748686214-e9df14d4d9d0", "https://www.instagram.com/traveljunkie", "https://www.linkedin.com/in/traveljunkie", 10, "9988776655", 4.0, "220$", "https://twitter.com/travel_junkie", "8", "Travel Junkie" },
                    { 9, "Your go-to source for fashion advice and trend updates, ensuring you stay stylish and on point.", "styleguru@gmail.com", "https://www.facebook.com/styleguru", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAAh1BMVEX///8AAAD8/Pzz8/P29vb5+fmcnJy+v76xsbFKSkqurq5gYGBBQUHx8fGSkpK1tbUuLi45OTlubm6MjIzf39/Z2dmgoKDm5uYzMzPFxcWAgH/Ly8taWloODg4WFxaoqKhSUlIlJSV2dnbU1NQeHh5nZ2ddXV1ycnKEhIQ+Pj5NTUwhIiEoKSjmaeRNAAANK0lEQVR4nO1da5uiLBhG1MrKLA9DpZ2nnWam///7Xh4wRcXUEvfd6+L+sLuZCbfAc4ZFSENDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0OjCdhKgf92T3oE52KR+BD4ibNecjhHPzhsiJXe8o8TduNFsjSkWCbBxqW34H+YYjRy5ORyOKPwb/fyZZDFZxM9jt8FkPynBpJ21vJ+2tHj+PHMv93pbiCjexd+gFNA/nav28MNutLjCNz/v9CB/tmL1/gxjvbT9Yj5t/jvvQhoeLx7nSCFh2o5/j+GN/zzFj+K5InyCMfjyL14h8MkdofjlIO+48O7/AAj2XDR6bGZw7e//KZdMPyQYmR2UhD1mFcHiNIZse9yCyIZmiJGcT/8AOPq0z24fkPH/CZvYIbpO+4Ji/LTzZNh7C8ICffMhmRH5fdXnwQN42oXFyMMIYyscMt5UPFqz/slSBdj0Yw7G8Yn/C24KT4ekCKp8Y/ewakgb6gWcoCPaC5FQxHEiLR0IrphJzLw6QX2LsUbBnOeya8KghSC8gdNuwBCk/zry1AEzb0igsZvvhbZ2HlAKU7Sb3eXgexT+1sVQcNY2lkz25QiiBduWdyGETQYH5/28U04qdKgBhNb62P4SJd9sjT2Q/nMW5UEQenxcXqYTCb91xbE6GY60CKczv2ZwmlqGAfeDp2dU/hIzXJE/bPpMOwAMFXssP1AhmTakSKXmDj1XBLqQ9G/PofU9gyXtn6vhcYdGe4tFjQGih+GcUSXK1wdzuyOt8n1QAeShy4+j8cG1WF2ZmhcoR0YsEN4NWYjn4mc5VBj6HNilw/eGWruN4jWFxim40USY3Uwkkk6W6JB+KUEqfI1MoYNQe5XGH5SCxWzd7g3suWQDDKGm3Jf1DA0tihMTfv1LFsFI1iaalnibAhVMzQusosHpew4KnEZKssbHMUKw1ZCOJE+daY0p4ORVZIq98UioK/1IwgWdyNYXMv9uS4WZYarRUwIiSaVeyuoeW9q01Zn5ngLnci/cgybR45EeCwEITDceZldTZo43qUutlppM6YOaSG65rDLmDO0UMV0oX5BgeEPpIDNeDxmGZmmSKvMalpbShk61JxChRTF6XNPlXOy/zwZO1PG0BYZHukzohn/4QGyAc8Z/lSzISu7oYvvIeZ93BRF559UlsoZimNI3z/6yL5zXPGTFJtKMO9HKUEEC+cLXuJYFDez1gzj4gRYWhLJXMAVlVMic6XKkAeEThv4d5QLnNYMr+VpSUdfqvRykPIb+FY6Sx/v37nAJ/fBsTXDTSG2Cxgj1DGgtbRUMjxl7ThTcBEv904M927F4psVY6FSnAuZg0+VDAsTaj+iTVnHLgy/q3ROrhgolGNanNoqAzW3Yst3OsXMeweGR1SRGwapGvJlUCcjXOUfVWZJKzHuD8QotWVI7dfJqASzRXrOp5MlyWw4hTZbVG2bILLrMoYySd8iAQnO8McyXSSxOoYSE2vEvIoOs9QyLRGmZdqNs5S9SQozp6sISbVlym3WaZb6p2UZbaqMVpj6vWkeQZ2DaJ+qLTsspJF5wKTqW4wFhg6qes/NuINh94WyBFQlUdwbJMvQODJDLmMYVW8KBct7iZvMUCkiCGYsMnvDV8ZQprduzK7MGE4RKoUVqRUp2DQhi+t2xQHZPvyZxgUcZQxvksYvyP1kDLn1OKuIIyoWBO/pIFGIzaBON/J2xsPL2CljKBE0Ca8lyCNRUSkmRS1rxtDlDNc2JuVnNIP59GSWfVZltlmrStPU2MCOIYwhUDaFjM0Kfih6T6Oi6Re0KjZamqw2KvusJiqMkZsugxPJPAySltM4eVkNFQg4c6u29N27bAyzBUjVdfigtZsiu1UakkD7eVRKlUIM8+ai7Xy5mnkYPZQDfauTBScGebDo5iyXzg3e9eLAxjCgFz9OKUW08ef3dTKiBqbZHG8zuJ0mGN+q1MWjiRnYF9iExWA9PAUHPl0K35tgoJErdQmtBzE+fQMr+z3arNsQBLcSC/P5qohhrsnOMTMvw1Fuia9jYYH5G9Z9K4ZRJel1OmLpPNsHzH9GrtdY0Z9iQm8WPp6U8MPFANt+1WBrrdPR+SOvfGv8fQHUhXHFILki/+m1Km66FjtXt1dA17Yrem6KvIuXGE5Q1RbvjhsvUsygyPZuyzASrBpqxZH3CsAZqCQ2xfi+Isu0JUMqRS6pBDnSKWq1k5aNDAvPWf1VhhDHRqE3GnmgxUgfBIFhsc5TzS6UtrP0U6hl9nqYopxhMTSuQNTgLpLGmYY2nVfRoa/6WjBiCubdqH+GqJRwYtifaodof6r/rjuoPkQF806NqCl6586UrQUcLU79MakDFHsV07JKsjNi3Hm9ya/jXvaTPAW0VlCrayUuohCB8SH9cznczoEHIxn2Xs9eAkhlVwyP3JVE9nPbd0s/bR6srkQeo+oT8BoLZpuSuDfOdC44L+Kq8FwlFe05WPl+MTKuxm5L4zRQpFsM2fQoNaU4QutMWS1/UjP+poRhWhcxkUfdFAJibdwD3iDMowp7W0U9RirNGvPSvQOmJAvRHcH04Atk09DZl8CJ3UrKV8DXVyWudPzy8zl8nV7CcDNKY3bz81e5KPXz6ywTyxAS8DgtjDAXqkr2d5ks4T4uBBQKQLKsRbYtI8h0WMR8D2p5leOT39Lik72bjtwRfvwIKyrRF2yEwvpJalcD/95Dj/3CQFgkClkEAgIbC4TLjsfKloU8oIAGw9t92NtsDimRpqx1t76M6QnDXxd2szNGR48/iprT7RiC3Q2hzCxfwYJ38/p+vg42eE8qRZ8wpBp6ky3Iox2eOjCEofswRJcpzfL0DsySPy8x9IpLdAUmQmuG0LZTTDlBFjJQsf1p+yJDB0sMu7YMITcKdUaifgArat2/SuQ7dF5hOJXVELdlCMzCQpUD5hug+1eJmKU/RYa3jxznJwylidG2DNNo9Lg4YizzrMCsCYoMxXCJV8/wbsnUXEuGN9jAtqtUs0FdxqV/gjAULzD8lm51a8kQRKbPs3ZCa2yeJn3TgxZmxVl6SPFhP2M4f4MhsBgZVd2AIZOlIrq/qZE0riqG4yyPXn7bU9D6/a9EfHerxqdChmvMhZRktAi73D/FaSirJdyZUIPRlWELu3TKvW1ZxtD9TW3xnmG5MsnvMIFuyXwLsqtheKsqye9SltK4Y26ETiQ9YTUSKgZRuos7YI4HkVVERUYNw2vV0byWq8Im3BjeS3dYwK2KjgGpKreQOY1jZJfm3Z5VUskZ3qvu5ESss+a3pGcO1HZDhU6kM/VU6tmWN+dXMtoHNk5yhnC+RemKVVoBIF9gnOWpJnavoqqF0kp00tVCJSouzOAffmsNw3N5a8K4FLtnEahlantLwF5nqGaLUCF4ObcR4jVnPiqcBrIirPq0jmF5f9GoHOMi6cusnYkJa1PNDpMwjzndhI0+U7ZvN8X1seenjuG3JRY8QklJIXAzRbwkqa4WMS2pVZIthbcW+/D4VQDmVD4SEKHYMBF5zdMpdQxZoZE7Aum0WkCBVKXoj/3wSZEXjPmXikF0t8zSt1ndEyKiWtuyPTsW+95M6yVrGRp7Zqtglz0nLsbO2UU8f15sOVI1iLERRBbv3KZc17wIeUVUmCWN50+i5McxZ+KOS7FWbqcRtrX5SU8SnijqHyM4ZsD3Z9K82jLxr+IBtPvj8VnVkHP1r5XnpLw8fuhHPaCYRU3dQs9nfJXxUHPbxhEa80KG/mEpzYquUjONasOGoCHsnd8pqHPDpSKlnrF/dJk02iwY2XclBae4ePxWv9iRx0HRhyY3Hu66gN+mBKGqzGh+mFfSqugiYOUo/UMW5e0FwrC1K+m21zslphtWM4o74QjsuFXP4VXLXOReKLrVHQpvYk3yh5Ovtim0YKlogzcVZJJtJu/gaD6OMYthc03rjpyUZL3hyRi/eMS1HLdHtsVmhmz78rWJqlNNMZZktl/HlL0zeDC3Yw9tBchF5VkSuKcqWWrOkjxyPyPgWbYKwmB26JEKu0Zo4Y3DynMEtpDy9C0INbYcFzaLlO1/xmxaRW33htRifslmKIV9Az3+p10XyA7cAIX7nzneLMEsGSXuCBi2rAR2j2C4qdGIIsw3zoo8FxcRXdpTiGG1jIXaPiQD1BRGCwBT/NzMRcqPoPJJemGM7PZHfGwhzqrGSRTA93rdOptxu3MoOSgwDqln2zo6EbjIZMHVIeAeOtlxqw+5kJ8Q9N12kmJ0AIbqdnhXGoxaL8jtpU6hx3ja4bDSTUid1cEYsj5fbo0BgOU2zm6XgcTjxa2lFo9iFCuKuMmQnqEaeud5zYmfe+fsPf9fgjo6CuGYylI/dIf/jyFI5C22iTN/HIAxd5Lzwot6t6/cMZrNk68PpccrPQG2HweZ2KqsY4wttYe41bc8VCM4+5eGhoaGhoaGhoaGhoaGhoaGhoaGhoaGhoaGhoaGhoaGhoaGhoaGhoaGhoaGgP8Ag7/BVE35HsoAAAAASUVORK5CYII=", "https://www.instagram.com/styleguru", "https://www.linkedin.com/in/styleguru", 11, "6677889900", 5.0, "200$", "https://twitter.com/style_guru", "9", "Style Guru" },
                    { 10, "Level up with the latest gaming news, reviews, and live streams. Your ultimate gaming destination.", "gamingenthusiast@gmail.com", "https://www.facebook.com/gamingenthusiast", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45", "https://www.instagram.com/gamingenthusiast", "https://www.linkedin.com/in/gamingenthusiast", 12, "5566778899", 5.0, "250$", "https://twitter.com/gaming_enthusiast", "10", "Gaming Enthusiast" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Caption", "Content", "CreatedAt", "MarketingAgencyId", "picContent" },
                values: new object[,]
                {
                    { 1, "BeyondFood Post 1", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3417), 1, "https://images.unsplash.com/photo-1512621776951-a57141f2eefd" },
                    { 2, "BeyondFood Post 2", "https://www.youtube.com/watch?v=CevxZvSJLk8", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3502), 1, "https://images.unsplash.com/photo-1556742031-c6961e8560b9" },
                    { 3, "BeyondFood Post 3", "https://www.youtube.com/watch?v=3JZ_D3ELwOQ", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3506), 1, "https://images.unsplash.com/photo-1561047029-3000e62f9c36" },
                    { 4, "BeyondFood Post 4", "https://www.youtube.com/watch?v=ZZ5LpwO-An4", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3509), 1, "https://images.unsplash.com/photo-1504674900247-0877df9cc836" },
                    { 5, "BeyondFood Post 5", "https://www.youtube.com/watch?v=V-_O7nl0Ii0", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3512), 1, "https://images.unsplash.com/photo-1481931715705-36a57477604e" },
                    { 6, "Explorernico Post 1", "https://www.youtube.com/watch?v=ZXsQAXx_ao0", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3523), 2, "https://images.unsplash.com/photo-1506748686214-e9df14d4d9d0" },
                    { 7, "Explorernico Post 2", "https://www.youtube.com/watch?v=2vjPBrBU-TM", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3531), 2, "https://images.unsplash.com/photo-1556740749-887f6717d7e4" },
                    { 8, "Explorernico Post 3", "https://www.youtube.com/watch?v=hY7m5jjJ9mM", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3534), 2, "https://images.unsplash.com/photo-1536220243043-8f4530d1a174" },
                    { 9, "Explorernico Post 4", "https://www.youtube.com/watch?v=K4TOrB7at0Y", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3537), 2, "https://images.unsplash.com/photo-1536220424265-cd4b86ad0b66" },
                    { 10, "Explorernico Post 5", "https://www.youtube.com/watch?v=60ItHLz5WEA", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3540), 2, "https://images.unsplash.com/photo-1516762689617-30b83c7540d1" },
                    { 11, "Evolve Post 1", "https://www.youtube.com/watch?v=aqz-KE-bpKQ", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3546), 3, "https://images.unsplash.com/photo-1529156069898-49953e39b3ac" },
                    { 12, "Evolve Post 2", "https://www.youtube.com/watch?v=Zi_XLOBDo_Y", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3549), 3, "https://images.unsplash.com/photo-1549921296-3a6b5cb03f6c" },
                    { 13, "Evolve Post 3", "https://www.youtube.com/watch?v=RgKAFK5djSk", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3551), 3, "https://images.unsplash.com/photo-1585079541686-b7bff75e4067" },
                    { 14, "Evolve Post 4", "https://www.youtube.com/watch?v=8UVNT4wvIGY", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3554), 3, "https://images.unsplash.com/photo-1593642532973-d31b6557fa68" },
                    { 15, "Evolve Post 5", "https://www.youtube.com/watch?v=J---aiyznGQ", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3557), 3, "https://images.unsplash.com/photo-1560807707-8cc77767d783" },
                    { 16, "Food Couple Post 1", "https://www.youtube.com/watch?v=6_b7RDuLwcI", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3579), 4, "https://images.unsplash.com/photo-1556742400-52b34cb48e20" },
                    { 17, "Food Couple Post 2", "https://www.youtube.com/watch?v=0J2QdDbelmY", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3582), 4, "https://images.unsplash.com/photo-1581320543175-8b32f60b3214" },
                    { 18, "Food Couple Post 3", "https://www.youtube.com/watch?v=1Cw1ng75KP0", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3585), 4, "https://images.unsplash.com/photo-1516763485050-6e068f0f3324" },
                    { 19, "Food Couple Post 4", "https://www.youtube.com/watch?v=ktvTqknDobU", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3587), 4, "https://images.unsplash.com/photo-1506089676908-3592f7389d4d" },
                    { 20, "Food Couple Post 5", "https://www.youtube.com/watch?v=9bZkp7q19f0", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3590), 4, "https://images.unsplash.com/photo-1495567720989-cebdbdd97913" },
                    { 21, "Social Media Queen Post 1", "https://www.youtube.com/watch?v=CevxZvSJLk8", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3593), 5, "https://images.unsplash.com/photo-1536243405184-d91150a7b25f" },
                    { 22, "Social Media Queen Post 2", "https://www.youtube.com/watch?v=3AtDnEC4zak", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3596), 5, "https://images.unsplash.com/photo-1500522144261-ea64433bbe27" },
                    { 23, "Social Media Queen Post 3", "https://www.youtube.com/watch?v=YQHsXMglC9A", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3599), 5, "https://images.unsplash.com/photo-1549921296-3a6b5cb03f6c" },
                    { 24, "Social Media Queen Post 4", "https://www.youtube.com/watch?v=oHg5SJYRHA0", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3601), 5, "https://images.unsplash.com/photo-1585079541686-b7bff75e4067" },
                    { 25, "Social Media Queen Post 5", "https://www.youtube.com/watch?v=fRh_vgS2dFE", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3604), 5, "https://images.unsplash.com/photo-1593642532973-d31b6557fa68" },
                    { 26, "Tech Trendsetter Post 1", "https://www.youtube.com/watch?v=opVNlmjOeSE", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3607), 6, "https://images.unsplash.com/photo-1560807707-8cc77767d783" },
                    { 27, "Tech Trendsetter Post 2", "https://www.youtube.com/watch?v=UO_84C3fpuI", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3609), 6, "https://images.unsplash.com/photo-1549921296-3a6b5cb03f6c" },
                    { 28, "Tech Trendsetter Post 3", "https://www.youtube.com/watch?v=ZZ5LpwO-An4", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3613), 6, "https://images.unsplash.com/photo-1585079541686-b7bff75e4067" },
                    { 29, "Tech Trendsetter Post 4", "https://www.youtube.com/watch?v=3JZ_D3ELwOQ", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3616), 6, "https://images.unsplash.com/photo-1593642532973-d31b6557fa68" },
                    { 30, "Tech Trendsetter Post 5", "https://www.youtube.com/watch?v=Zi_XLOBDo_Y", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3624), 6, "https://images.unsplash.com/photo-1560807707-8cc77767d783" },
                    { 31, "Fitness Freak Post 1", "https://www.youtube.com/watch?v=9bZkp7q19f0", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3654), 7, "https://images.unsplash.com/photo-1556742400-52b34cb48e20" },
                    { 32, "Fitness Freak Post 2", "https://www.youtube.com/watch?v=V-_O7nl0Ii0", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3657), 7, "https://images.unsplash.com/photo-1581320543175-8b32f60b3214" },
                    { 33, "Fitness Freak Post 3", "https://www.youtube.com/watch?v=0J2QdDbelmY", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3660), 7, "https://images.unsplash.com/photo-1516763485050-6e068f0f3324" },
                    { 34, "Fitness Freak Post 4", "https://www.youtube.com/watch?v=ktvTqknDobU", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3662), 7, "https://images.unsplash.com/photo-1506089676908-3592f7389d4d" },
                    { 35, "Fitness Freak Post 5", "https://www.youtube.com/watch?v=ZZ5LpwO-An4", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3665), 7, "https://images.unsplash.com/photo-1495567720989-cebdbdd97913" },
                    { 36, "Travel Junkie Post 1", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3668), 8, "https://images.unsplash.com/photo-1512621776951-a57141f2eefd" },
                    { 37, "Travel Junkie Post 2", "https://www.youtube.com/watch?v=3AtDnEC4zak", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3671), 8, "https://images.unsplash.com/photo-1556742031-c6961e8560b9" },
                    { 38, "Travel Junkie Post 3", "https://www.youtube.com/watch?v=CevxZvSJLk8", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3673), 8, "https://images.unsplash.com/photo-1561047029-3000e62f9c36" },
                    { 39, "Travel Junkie Post 4", "https://www.youtube.com/watch?v=RgKAFK5djSk", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3676), 8, "https://images.unsplash.com/photo-1504674900247-0877df9cc836" },
                    { 40, "Travel Junkie Post 5", "https://www.youtube.com/watch?v=60ItHLz5WEA", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3679), 8, "https://images.unsplash.com/photo-1481931715705-36a57477604e" },
                    { 41, "Style Guru Post 1", "https://www.youtube.com/watch?v=nfWlot6h_JM", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3681), 9, "https://images.unsplash.com/photo-1506748686214-e9df14d4d9d0" },
                    { 42, "Style Guru Post 2", "https://www.youtube.com/watch?v=2vjPBrBU-TM", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3684), 9, "https://images.unsplash.com/photo-1556740749-887f6717d7e4" },
                    { 43, "Style Guru Post 3", "https://www.youtube.com/watch?v=hY7m5jjJ9mM", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3687), 9, "https://images.unsplash.com/photo-1536220243043-8f4530d1a174" },
                    { 44, "Style Guru Post 4", "https://www.youtube.com/watch?v=K4TOrB7at0Y", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3689), 9, "https://images.unsplash.com/photo-1536220424265-cd4b86ad0b66" },
                    { 45, "Style Guru Post 5", "https://www.youtube.com/watch?v=60ItHLz5WEA", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3692), 9, "https://images.unsplash.com/photo-1516762689617-30b83c7540d1" },
                    { 46, "Gaming Enthusiast Post 1", "https://www.youtube.com/watch?v=aqz-KE-bpKQ", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3695), 10, "https://images.unsplash.com/photo-1529156069898-49953e39b3ac" },
                    { 47, "Gaming Enthusiast Post 2", "https://www.youtube.com/watch?v=Zi_XLOBDo_Y", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3697), 10, "https://images.unsplash.com/photo-1549921296-3a6b5cb03f6c" },
                    { 48, "Gaming Enthusiast Post 3", "https://www.youtube.com/watch?v=RgKAFK5djSk", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3700), 10, "https://images.unsplash.com/photo-1585079541686-b7bff75e4067" },
                    { 49, "Gaming Enthusiast Post 4", "https://www.youtube.com/watch?v=8UVNT4wvIGY", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3703), 10, "https://images.unsplash.com/photo-1593642532973-d31b6557fa68" },
                    { 50, "Gaming Enthusiast Post 5", "https://www.youtube.com/watch?v=J---aiyznGQ", new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3706), 10, "https://images.unsplash.com/photo-1560807707-8cc77767d783" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_UserId",
                table: "Administrators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CustomerId",
                table: "Appointments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_MarketingAgencyId",
                table: "Appointments",
                column: "MarketingAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MarketingAgencyId",
                table: "Customers",
                column: "MarketingAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_CustomerId",
                table: "Feedbacks",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_MarketingAgencyId",
                table: "Feedbacks",
                column: "MarketingAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingAgency_LocationId",
                table: "MarketingAgency",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingAgency_UserId",
                table: "MarketingAgency",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingAgencyCategory_CategoryId",
                table: "MarketingAgencyCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingAgencyCategory_MarketingAgencyId_CategoryId",
                table: "MarketingAgencyCategory",
                columns: new[] { "MarketingAgencyId", "CategoryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarketingAgencyContractTypes_ContractTypeId",
                table: "MarketingAgencyContractTypes",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingAgencyContractTypes_MarketingAgencyId_ContractTypeId",
                table: "MarketingAgencyContractTypes",
                columns: new[] { "MarketingAgencyId", "ContractTypeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_MarketingAgencyId",
                table: "Posts",
                column: "MarketingAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_CategoryId",
                table: "Proposals",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_ContractTypeId",
                table: "Proposals",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_CustomerId",
                table: "Proposals",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_MarketingAgencyId",
                table: "Proposals",
                column: "MarketingAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CustomerId",
                table: "Reports",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_MarketingAgencyId",
                table: "Reports",
                column: "MarketingAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "MarketingAgencyCategory");

            migrationBuilder.DropTable(
                name: "MarketingAgencyContractTypes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Proposals");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ContractTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MarketingAgency");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
