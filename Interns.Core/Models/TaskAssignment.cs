
// Interns.Core/Models/TaskAssignment.cs
namespace Interns.Core.Models
{
    public class TaskAssignment
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid InternId { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}

