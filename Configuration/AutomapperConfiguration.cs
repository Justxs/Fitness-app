using AutoMapper;
using FitnessApp.Database.DTO;
using FitnessApp.Database.DTO.FoodRecord;
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
            CreateMap<List<FoodRecord>,FoodRecordDtoAggregate>(MemberList.None)
                .ForMember(x => x.Calories,opt => opt.MapFrom(x=>x.Sum(x=>x.Calories)))
                .ForMember(x => x.Proteins, opt => opt.MapFrom(x => x.Sum(x => x.Proteins)))
                .ForMember(x => x.Carbohydrates, opt => opt.MapFrom(x => x.Sum(x => x.Carbohydrates)))
                .ForMember(x => x.Fats, opt => opt.MapFrom(x => x.Sum(x => x.Fats)))
                .ForMember(x=>x.User, opt => opt.MapFrom(x=>x.First().User));

            CreateMap<UserDtoLogin, User>(MemberList.None);

            CreateMap<UserDtoRegister, User>(MemberList.None)
                .ForMember(x => x.UserName, opt => opt.MapFrom(src => src.Email));
            CreateMap<UserDtoUpdate, User>(MemberList.None);
            CreateMap<User, UserDtoGet>(MemberList.None);
        }
    }
}
