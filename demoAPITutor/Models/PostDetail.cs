using System.ComponentModel.DataAnnotations;
using demoAPITutor.Enums;

namespace demoAPITutor.Models
{
    public class PostDetail
    {
        [Key]
        public int Id { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; } = null!;
        public string Title { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; } 
        public string Address { get; set; }
        public Location Location { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public PostStatus PostStatus { get; set; }
    }
}
