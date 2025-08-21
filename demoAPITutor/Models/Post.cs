using System.ComponentModel.DataAnnotations;
using demoAPITutor.Enums;

namespace demoAPITutor.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;

        public int GradeId { get; set; } 
        public Grade Grade { get; set; } = null!;
        public PostType PostType { get; set; }
        public PostDetail PostDetail { get; set; }
        public ICollection<Request> Requests { get; set; } = new List<Request>();

    }
}
