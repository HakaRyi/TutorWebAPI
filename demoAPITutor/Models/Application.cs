using System.ComponentModel.DataAnnotations;

namespace demoAPITutor.Models
{
    public enum Status
    {
        Pending, Approved, Rejected
    }
    public class Application
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string Title { get; set; }
        public string Content { get; set; } 
        public DateTime CreatedAt { get; set; }
        public User User { get; set; } = null!;
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
