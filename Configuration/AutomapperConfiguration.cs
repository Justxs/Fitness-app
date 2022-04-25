using AutoMapper;
using FitnessApp.Database.DTO;
using FitnessApp.Database.Models;

namespace FitnessApp.Configuration
{
    public class AutoMapperConfiguration: Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<FoodProductDtoCreate, FoodProduct>(MemberList.None);
            CreateMap<FoodProductDtoUpdate, FoodProduct>(MemberList.None);
            CreateMap<FoodProduct, FoodProductDtoGet>(MemberList.None);
            CreateMap<FoodProductDtoGet, FoodProduct>(MemberList.None);
        }
    }
}
