using AutoMapper;
using demoAPITutor.DTOs.Request;
using demoAPITutor.DTOs.Response;
using demoAPITutor.Models;

namespace demoAPITutor.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<SignUpRequest, User>()
                .ForMember(dest => dest.Password, opt => opt.Ignore()) 
                // Bỏ qua thuộc tính Password, vì bạn sẽ hash thủ công.
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore()); 
                // Bỏ qua CreatedAt, vì nó có giá trị mặc định trong Model.

            // Cấu hình ánh xạ từ User (Model) sang UserResponse (DTO)
            CreateMap<User, UserResponse>();

        }
    }
}
