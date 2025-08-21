namespace demoAPITutor.Models
{
    public class TutorSubject
    {
        public int TutorId  { get; set; }
        public User Tutor { get; set; } = null!;
        public int SubjectId {  get; set; } 
        public Subject Subject { get; set; } = null!;
    }
}
