
// Interns.Core/Models/Quiz.cs
namespace Interns.Core.Models
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}