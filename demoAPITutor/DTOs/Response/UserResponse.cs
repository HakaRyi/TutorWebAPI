using demoAPITutor.Enums;
using demoAPITutor.Models;
using System.ComponentModel.DataAnnotations;

namespace demoAPITutor.DTOs.Response
{
    public class UserResponse
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int? Age { get; set; }
        public string Sex { get; set; }
        public string Role { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentProfileResponse StudentProfile { get; set; } = new StudentProfileResponse();
        public TutorProfileResponse TutorProfile { get; set; }  = new TutorProfileResponse();   
    }
}
