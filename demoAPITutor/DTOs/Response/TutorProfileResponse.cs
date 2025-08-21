namespace demoAPITutor.DTOs.Response
{
    public class TutorProfileResponse
    {
        public int Id { get; set; }
        public string Certificate { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public List<string> SubjectsTaught { get; set; } = new List<string>();
        public List<string> GradesTaught { get; set; } = new List<string>();
        public double AverageRating { get; set; }
    }
}
