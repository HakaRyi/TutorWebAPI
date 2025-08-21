using System.ComponentModel.DataAnnotations;
using demoAPITutor.Enums;

namespace demoAPITutor.Models
{
    public class Request
    {
        public int Id { get; set; } 
        public int StudentId { get; set; }
        public int PostId { get; set; }
        public string Description { get; set; }
        public int ReceiverId { get; set; } 
        public DateTime CreatedAt { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public User Receiver { get; set; } = null!;
        public User Student { get; set; } = null!;
        public Post Post { get; set; } = null!;
    }
}
