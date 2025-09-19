using Interns.Core.Models;
using Microsoft.EntityFrameworkCore;


namespace Interns.Api.Data
{
    public class InternsDbContext : DbContext
    {
        public InternsDbContext(DbContextOptions<InternsDbContext> options) : base(options) { }


        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<TaskAssignment> TaskAssignments { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<QuizResponse> QuizResponses { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<FileImport> FileImports { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<ApplicationUser>().HasIndex(u => u.EmployeeId).IsUnique();
            modelBuilder.Entity<TaskAssignment>().HasKey(t => t.Id);
            // Add other indexes/constraints as needed
        }
    }
}