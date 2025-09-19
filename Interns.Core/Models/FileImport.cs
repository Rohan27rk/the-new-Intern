// Interns.Core/Models/FileImport.cs
namespace Interns.Core.Models
{
    public class FileImport
    {
        public Guid Id { get; set; }
        public Guid UploadedById { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string RawJson { get; set; } // JSON representation of the quiz data
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    }
}