using System.ComponentModel.DataAnnotations;
using demoAPITutor.Enums;

namespace demoAPITutor.DTOs.Request
{
    public class SignUpRequest
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Username at least 3 characters")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Wrong email format!")]
        [StringLength(20, ErrorMessage = "Email not more than 20 characters")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(3, ErrorMessage = "Password at least 3 characters")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required")]
        [Compare("Password", ErrorMessage = "ConfirmPassword and Password do not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(3, ErrorMessage = "Password at least 3 characters")]
        public string PhoneNumber { get; set; }
        public int? Age { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public UserSex Sex { get; set; }
        [Required(ErrorMessage = "Role is required")]
        public UserRole Role { get; set; }
        [Required(ErrorMessage = "Fullname is required")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        public string? AvatarUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
