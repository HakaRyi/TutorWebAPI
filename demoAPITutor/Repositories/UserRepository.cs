using demoAPITutor.Data;
using demoAPITutor.Enums;
using demoAPITutor.Models;
using Microsoft.EntityFrameworkCore;

namespace demoAPITutor.Repositories
{
    public class UserRepository : IUserRepository
    {
        public readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            if (subject != null)
            {
                _context.Subjects.Remove(subject);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllStudentsAsync()
        {
            return await _context.Users
                                .Where(u => u.Role == UserRole.Student)     
                                .ToListAsync();
        }

        public async Task<IEnumerable<User>> GetAllTutorsAsync()
        {
                return await _context.Users
                                     .Where(u => u.Role == UserRole.Tutor)
                                     .Include(u => u.TutorSubjects)
                                     .ThenInclude(us => us.Subject)
                                     //.ThenInclude(tp => tp.TutorGrades)
                                     //   .ThenInclude(tg => tg.Grade)
                                     .Include(u => u.ReceivedFeedbacks)
                                     .ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<bool> IsEmailExistAsync(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<bool> IsUsernameExistAsync(string username)
        {
            return await _context.Users.AnyAsync(u => u.Username == username);
        }

        public async Task UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
