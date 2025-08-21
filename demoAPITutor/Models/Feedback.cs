using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace demoAPITutor.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int StudentId { get; set; }
        public User Student { get; set; } = null!;
        public int TutorId { get; set; }
        public User Tutor { get; set; } = null!;

    }
}
