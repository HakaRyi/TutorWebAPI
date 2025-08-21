using System.ComponentModel.DataAnnotations;
using demoAPITutor.Enums;

namespace demoAPITutor.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int? Age { get; set; }
        public UserSex Sex { get; set; }
        public UserRole Role { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string? AvatarUrl { get; set; }
        public DateTime CreatedAt { get; set; } 
        public bool IsActive { get; set; }
        public TutorProfile? TutorProfile { get; set; }
        public StudentProfile? StudentProfile { get; set; }
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<Post> CreatePosts { get; set; }  = new List <Post>();
        public ICollection<Feedback> GivenFeedbacks { get; set; } = new List<Feedback>();
        public ICollection<Feedback> ReceivedFeedbacks { get; set; } = new List<Feedback>();
        public ICollection<Request> SendRequests { get; set; } = new List<Request>();
        public ICollection<Request> ReceivedRequests { get; set; } = new List<Request>();
        public ICollection<TutorGrade> TutorGrades { get; set; } = new List<TutorGrade>();
        public ICollection<TutorSubject> TutorSubjects { get; set; } = new List<TutorSubject>();

    }
}
