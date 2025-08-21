using System.ComponentModel.DataAnnotations;

namespace demoAPITutor.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public ICollection<StudentProfile> StudentProfiles { get; set; } = new List<StudentProfile>();  
        public ICollection<TutorGrade> TutorGrades { get; set; } = new List<TutorGrade>();
        public ICollection<Post> Post { get; set; } = new List<Post>();
    }
}
