
// Interns.Core/Models/QuizQuestion.cs
namespace Interns.Core.Models
{
    public class QuizQuestion
    {
        public Guid Id { get; set; }
        public Guid QuizId { get; set; }
        public string QuestionText { get; set; }
        // Store options and correct answer as JSON for flexibility
        public string OptionsJson { get; set; }
        public string CorrectAnswer { get; set; }
        public int Severity { get; set; } // 1..5
    }
}
