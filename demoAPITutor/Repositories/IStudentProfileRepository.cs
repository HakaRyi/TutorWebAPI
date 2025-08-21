using demoAPITutor.Models;

namespace demoAPITutor.Repositories
{
    public interface IStudentProfileRepository : IRepository<StudentProfile>
    {
        Task<StudentProfile> GetByStudentIdAsync(int studentId);
    }
}
