using AutoMapper;
using FitnessApp.Database.DTO;
using FitnessApp.Database.Models;

namespace FitnessApp.Configuration
{
    public class AutoMapperConfiguration: Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<FoodProductDtoForm, FoodProduct>(MemberList.None);
            CreateMap<FoodProductDtoForm, FoodProduct>(MemberList.None);
            CreateMap<FoodProduct, FoodProductDtoGet>(MemberList.None);
            CreateMap<FoodProductDtoGet, FoodProduct>(MemberList.None);
        }
    }
}
