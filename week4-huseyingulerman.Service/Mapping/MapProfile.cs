using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.DTOs.Update;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AppUser, UserDTO>();
            CreateMap<UserCreateDTO, AppUser>();
            CreateMap<UserDTO, UserCreateDTO>();
            CreateMap<UserCreateDTO, UserDTO>();


            CreateMap<Pet, PetDTO>().ReverseMap();
            CreateMap<PetCreateDTO, Pet>();
            CreateMap<PetDTO, PetCreateDTO>();
            CreateMap<PetCreateDTO, PetDTO>();
            CreateMap<PetUpdateDTO, Pet>();

            CreateMap<Health, HealthDTO>().ReverseMap();
            CreateMap<HealthCreateDTO, Health>().ReverseMap();
            CreateMap<HealthDTO, HealthCreateDTO>().ReverseMap();
            CreateMap<HealthCreateDTO, HealthDTO>().ReverseMap();
            CreateMap<HealthUpdateDTO, Health>().ReverseMap();
            CreateMap<HealthUpdateDTO, HealthDTO>().ReverseMap();

            CreateMap<Activity, ActivityDTO>();
            CreateMap<ActivityCreateDTO, Activity>();
            CreateMap<ActivityDTO, ActivityCreateDTO>();
            CreateMap<ActivityCreateDTO, ActivityDTO>();

            CreateMap<Food, FoodDTO>();
            CreateMap<FoodCreateDTO, Food>();
            CreateMap<FoodDTO, FoodCreateDTO>();
            CreateMap<FoodCreateDTO, FoodDTO>();

            //CreateMap<FoodPet, FoodPetDTO>();
            //CreateMap<FoodPetCreateDTO, FoodPet>();
            //CreateMap<FoodPetDTO, FoodPetCreateDTO>();
            //CreateMap<FoodPetCreateDTO, FoodPetDTO>();



            CreateMap<FoodPet, FoodPetDTO>()
               .ForMember(dest => dest.PetName, opt => opt.MapFrom(src => src.Pet.Name))
               .ForMember(dest => dest.FoodName, opt => opt.MapFrom(src => src.Food.Name));
              /* .ForMember(dest => dest.FoodDate, opt => opt.MapFrom(src => src.CreatedDate)).ReverseMap()*/;



        }
    }
}
