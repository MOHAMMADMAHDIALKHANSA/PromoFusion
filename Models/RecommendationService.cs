using MarketingHub.Data;
using MarketingHub.Models;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System.Linq;

namespace MarketingHub.Services
{
    public class RecommendationService
    {
        private readonly ApplicationDbContext _context;
        private readonly MLContext _mlContext;
        private readonly ITransformer _model;

        public RecommendationService(ApplicationDbContext context)
        {
            _context = context;
            _mlContext = new MLContext();
            _model = TrainModel();
        }

        private ITransformer TrainModel()
        {
            var data = _context.Feedbacks.Select(f => new FeedbackData
            {
                CustomerId = f.CustomerId,
                MarketingAgencyId = f.MarketingAgencyId,
                Comment = f.Comment,
                Rating = f.Rating
            }).ToList();

            if (!data.Any())
            {
                // Log a warning or information message
                Console.WriteLine("No feedback data available for training the model.");
                return null;
            }

            var trainData = _mlContext.Data.LoadFromEnumerable(data);

            var dataProcessingPipeline = _mlContext.Transforms.Conversion.MapValueToKey(nameof(FeedbackData.CustomerId))
                .Append(_mlContext.Transforms.Conversion.MapValueToKey(nameof(FeedbackData.MarketingAgencyId)))
                .Append(_mlContext.Transforms.Text.FeaturizeText("CommentFeaturized", nameof(FeedbackData.Comment)));

            var options = new MatrixFactorizationTrainer.Options
            {
                MatrixColumnIndexColumnName = nameof(FeedbackData.CustomerId),
                MatrixRowIndexColumnName = nameof(FeedbackData.MarketingAgencyId),
                LabelColumnName = nameof(FeedbackData.Rating),
                NumberOfIterations = 20,
                ApproximationRank = 100
            };

            var trainer = _mlContext.Recommendation().Trainers.MatrixFactorization(options);
            var trainingPipeline = dataProcessingPipeline.Append(trainer);

            return trainingPipeline.Fit(trainData);
        }




        public List<AgencyRecommendation> RecommendAgencies(string customerId, int numberOfRecommendations = 5)
        {
            if (_model == null)
            {
                // No model available, return an empty list or default recommendations
                Console.WriteLine("Recommendation model is not trained. Returning no recommendations.");
                return new List<AgencyRecommendation>();
            }

            var predictionEngine = _mlContext.Model.CreatePredictionEngine<FeedbackData, RatingPrediction>(_model);

            var agencies = _context.MarketingAgency.Select(a => a.MarketingAgencyId).ToList();
            var predictions = new List<AgencyRecommendation>();

            foreach (var agencyId in agencies)
            {
                var prediction = predictionEngine.Predict(new FeedbackData
                {
                    CustomerId = customerId,
                    MarketingAgencyId = agencyId
                });

                predictions.Add(new AgencyRecommendation
                {
                    MarketingAgencyId = agencyId,
                    Score = prediction.Score
                });
            }

            return predictions.OrderByDescending(p => p.Score).Take(numberOfRecommendations).ToList();
        }



        private class FeedbackData
        {
            public string CustomerId { get; set; }
            public int MarketingAgencyId { get; set; }
            public float Rating { get; set; }
            public string Comment { get; set; }
        }

        private class RatingPrediction
        {
            public float Score { get; set; }
        }
    }
}
