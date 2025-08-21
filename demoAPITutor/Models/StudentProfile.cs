using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace demoAPITutor.Models
{
    public class StudentProfile
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public User Student { get; set; } 

        public int? GradeId { get; set; } 
        public Grade? Grade { get; set; } 
    }
}
