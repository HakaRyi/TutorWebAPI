using System.ComponentModel.DataAnnotations;
using demoAPITutor.Enums;

namespace demoAPITutor.Models
{
    public class TutorProfile
    {
        [Key]
        public int Id { get; set; }
        public int TutorId { get; set; } 
        public User Tutor { get; set; } = null!;
        public string Certificate { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; } 
        public ICollection<TutorSubject> TutorSubjects { get; set; } = new List<TutorSubject>();
        public ICollection<TutorGrade> TutorGrades { get; set; } = new List<TutorGrade>();
    }
}
