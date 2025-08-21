using demoAPITutor.Data;
using demoAPITutor.Models;
using Microsoft.EntityFrameworkCore;

namespace demoAPITutor.Repositories
{
    public class StudentProfileRepository : IStudentProfileRepository
    {
        public readonly ApplicationDbContext _context;

        public StudentProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }
            
        public Task AddAsync(StudentProfile entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();    
        }

        public async Task<StudentProfile> GetByStudentIdAsync(int studentId)
        {
            return await _context.StudentProfiles.FirstOrDefaultAsync(sp => sp.StudentId == studentId);
        }

        public Task<IEnumerable<StudentProfile>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StudentProfile> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(StudentProfile entity)
        {
            throw new NotImplementedException();
        }
    }
}
