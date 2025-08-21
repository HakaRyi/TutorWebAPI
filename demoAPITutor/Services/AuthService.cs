using AutoMapper;
using demoAPITutor.DTOs.Request;
using demoAPITutor.DTOs.Response;
using demoAPITutor.Enums;
using demoAPITutor.Helper;
using demoAPITutor.Models;
using demoAPITutor.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace demoAPITutor.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IStudentProfileRepository _studentProfileRepository;
        private readonly IMapper _mapper;

        public AuthService(IUserRepository userRepository, IStudentProfileRepository studentProfileRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _studentProfileRepository = studentProfileRepository;
            _mapper = mapper;
        }
        public Task<UserResponse> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> RegisterUserAsync(SignUpRequest request)
        {
            throw new NotImplementedException();

            //if (await _userRepository.IsEmailExistAsync(request.Email))
            //{
            //    throw new ArgumentException("Email already existed!");
            //}
            //var user = new User
            //{
            //    Username = request.Username,
            //    Email = request.Email,
            //    Password = PasswordHasher.HashPassword(request.Password),
            //    PhoneNumber = request.PhoneNumber,
            //    Age = request.Age,
            //    Sex = request.Sex,
            //    Role = request.Role,
            //    Fullname = request.Fullname,
            //    Address = request.Address,
            //    AvatarUrl = request.AvatarUrl,
            //    CreatedAt = request.CreatedAt
            //};
            //user.CreatedAt = DateTime.UtcNow;


        }
    }
}
