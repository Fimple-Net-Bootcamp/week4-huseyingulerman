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
               .ForMember(dest => dest.FoodName, opt => opt.MapFrom(src => src.Food.Name)).ReverseMap();
              /* .ForMember(dest => dest.FoodDate, opt => opt.MapFrom(src => src.CreatedDate)).ReverseMap()*/;

            CreateMap<Pet, PetStatisticDTO>()
             .ForMember(dest => dest.PetName, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.FoodName, opt => opt.MapFrom(src => src.PetsFoods.Select(x=>x.Food.Name).ToList()))
              .ForMember(dest => dest.ActivityName, opt => opt.MapFrom(src => src.PetsActivities.Select(x => x.Activity.Name).ToList()))
               .ForMember(dest => dest.HealthName, opt => opt.MapFrom(src => src.Healths.Select(x => x.Situation).ToList()));


            CreateMap<Pet, UserStatisticDTO>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.AppUser.UserName))
            .ForMember(dest => dest.PetName, opt => opt.MapFrom(src => src.AppUser.Pets.Select(x=>x.Name).ToList()))
             .ForMember(dest => dest.FoodName, opt => opt.MapFrom(src => src.PetsFoods.Select(x => x.Food.Name).ToList()))
             .ForMember(dest => dest.ActivityName, opt => opt.MapFrom(src => src.PetsActivities.Select(x => x.Activity.Name).ToList()))
              .ForMember(dest => dest.HealthName, opt => opt.MapFrom(src => src.Healths.Select(x => x.Situation).ToList()));



            CreateMap<PetTraining, PetTrainingDTO>()
               .ForMember(dest => dest.PetName, opt => opt.MapFrom(src => src.Pet.Name))
               .ForMember(dest => dest.TrainingName, opt => opt.MapFrom(src => src.Training.Name))
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ReverseMap();

            CreateMap<PetTraining, PetWithTrainingDTO>()
                 .ForMember(dest => dest.PetName, opt => opt.MapFrom(src => src.Training.TrainingsPets.Select(x => x.Pet.Name).ToList()))
                 .ForMember(dest => dest.TrainingName, opt => opt.MapFrom(src => src.Training.TrainingsPets.Select(x=>x.Training.Name).ToList()))
                  .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Training.TrainingsPets.Select(x => x.Training.Price).ToList()))
                  .ForMember(dest => dest.Species, opt => opt.MapFrom(src => src.Pet.PetsTrainings.Select(x => x.Pet.Species).ToList()));


            CreateMap<SocialInteractionPet, PetSocialInteractionDTO>()
             .ForMember(dest => dest.PetName, opt => opt.MapFrom(src => src.Pet.Name))
             .ForMember(dest => dest.SocialInteractionName, opt => opt.MapFrom(src => src.SocialInteraction.Name))
             .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
             .ReverseMap();

            CreateMap<SocialInteractionPet, PetWithSocialInteractionDTO>()
                 .ForMember(dest => dest.PetName, opt => opt.MapFrom(src => src.SocialInteraction.SocialInteractionPets.Select(x => x.Pet.Name).ToList()))
                 .ForMember(dest => dest.SocialInteactionName, opt => opt.MapFrom(src => src.SocialInteraction.SocialInteractionPets.Select(x => x.SocialInteraction.Name).ToList()))
                  .ForMember(dest => dest.Place, opt => opt.MapFrom(src => src.Pet.PetsSocialInteraction.Select(x => x.SocialInteraction.Place).ToList()))
                  .ForMember(dest => dest.Species, opt => opt.MapFrom(src => src.Pet.PetsSocialInteraction.Select(x => x.Pet.Species).ToList()));
        }
    }
}
