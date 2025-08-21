using System.ComponentModel.DataAnnotations;

namespace demoAPITutor.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public ICollection<TutorSubject> TutorSubjects { get; set; }  = new List<TutorSubject>();
        public ICollection<Post> Post { get; set; } = new List<Post>();
    }
}
