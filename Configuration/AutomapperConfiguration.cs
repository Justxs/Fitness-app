using AutoMapper;
using FitnessApp.Database.DTO;
using FitnessApp.Database.DTO.User;
using FitnessApp.Database.Models;

namespace FitnessApp.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<FoodRecordDtoForm, FoodRecord>(MemberList.None);
            CreateMap<FoodRecord, FoodRecordDtoGet>(MemberList.None);

            CreateMap<UserDtoLogin, User>(MemberList.None);

            CreateMap<UserDtoRegister, User>(MemberList.None)
                .ForMember(x => x.UserName, opt => opt.MapFrom(src => src.Email));
            CreateMap<UserDtoUpdate, User>(MemberList.None);
            CreateMap<User, UserDtoGet>(MemberList.None);
        }
    }
}
