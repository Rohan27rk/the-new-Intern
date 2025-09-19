// Interns.Core/Models/Submission.cs

namespace Interns.Core.Models
{
    public class Submission
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid InternId { get; set; }
        public string GitHubRepoUrl { get; set; }
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
        public double? Score { get; set; }
        public string Feedback { get; set; }
    }
}




