namespace demoAPITutor.Models
{
    public class TutorGrade
    {
        public int TutorId  { get; set; }
        public User Tutor  { get; set; } = null!;
        public int GradeId {  get; set; } 
        public Grade Grade { get; set; } = null!;
    }
}
