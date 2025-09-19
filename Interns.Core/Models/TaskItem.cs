// Interns.Core/Models/TaskItem.cs
using System.ComponentModel.DataAnnotations;


namespace Interns.Core.Models
{
    public class TaskItem
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid CreatedById { get; set; } // trainer id
        public DateTime Deadline { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}


