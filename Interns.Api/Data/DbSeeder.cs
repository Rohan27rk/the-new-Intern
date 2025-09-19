using Interns.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Interns.Api.Helpers;

namespace Interns.Api.Data
{
    public static class DbSeeder
    {
        public static void Seed(InternsDbContext context)
        {
            context.Database.Migrate();

            // Admin
            if (!context.Users.Any(u => u.Role == Role.Admin))
            {
                var admin = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = "ADMIN001",
                    FullName = "Admin User",
                    Role = Role.Admin,
                    PasswordHash = PasswordHelper.HashPassword("Admin@123"),
                    CreatedAt = DateTime.UtcNow
                };
                context.Users.Add(admin);
            }

            // Manager
            if (!context.Users.Any(u => u.Role == Role.Manager))
            {
                var manager = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = "MGR001",
                    FullName = "Manager One",
                    Email = "manager@example.com",
                    Role = Role.Manager,
                    PasswordHash = PasswordHelper.HashPassword("Manager@123"),
                    CreatedAt = DateTime.UtcNow
                };
                context.Users.Add(manager);
            }

            // Trainer
            if (!context.Users.Any(u => u.Role == Role.Trainer))
            {
                var trainer = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = "TRN001",
                    FullName = "Trainer One",
                    Email = "trainer@example.com",
                    Role = Role.Trainer,
                    PasswordHash = PasswordHelper.HashPassword("Trainer@123"),
                    CreatedAt = DateTime.UtcNow
                };
                context.Users.Add(trainer);
            }

            // Intern
            if (!context.Users.Any(u => u.Role == Role.Intern))
            {
                var intern = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = "INT001",
                    FullName = "Intern One",
                    Email = "intern@example.com",
                    Role = Role.Intern,
                    PasswordHash = PasswordHelper.HashPassword("Intern@123"),
                    CreatedAt = DateTime.UtcNow
                };
                context.Users.Add(intern);
            }

            context.SaveChanges();
        }
    }
}
