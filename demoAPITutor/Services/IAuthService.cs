using demoAPITutor.DTOs.Request;
using demoAPITutor.DTOs.Response;

namespace demoAPITutor.Services
{
    public interface IAuthService
    {
        Task<UserResponse> RegisterUserAsync(SignUpRequest request);
        Task<UserResponse> GetUserByIdAsync(int id);
    }
}
