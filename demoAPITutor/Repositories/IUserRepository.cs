using demoAPITutor.Models;

namespace demoAPITutor.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByUsernameAsync(string username); // Để đăng nhập
        Task<IEnumerable<User>> GetAllTutorsAsync(); // Đã sửa lỗi
        Task<IEnumerable<User>> GetAllStudentsAsync();// Đã sửa lỗi
        Task<bool> IsUsernameExistAsync(string username);
        Task<bool> IsEmailExistAsync(string email);
    }
}