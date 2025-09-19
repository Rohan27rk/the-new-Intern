
// Interns.Core/Models/QuizResponse.cs
namespace Interns.Core.Models
{
    public class QuizResponse
    {
        public Guid Id { get; set; }
        public Guid QuizId { get; set; }
        public Guid InternId { get; set; }
        public string AnswersJson { get; set; }
        public double? Score { get; set; }
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}