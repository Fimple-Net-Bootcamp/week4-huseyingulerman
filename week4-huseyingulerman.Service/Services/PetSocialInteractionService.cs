using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Repositories;
using week4_huseyingulerman.Core.Result.Abstract;
using week4_huseyingulerman.Core.Result.Concrete;
using week4_huseyingulerman.Core.Services;
using week4_huseyingulerman.Core.UnitOfWork;
using week4_huseyingulerman.Repository.Repositories;

namespace week4_huseyingulerman.Service.Services
{
    public class PetSocialInteractionService : Service<SocialInteractionPet, PetSocialInteractionCreateDTO, PetSocialInteractionDTO>, IPetSocialInteractionService
    {
        protected readonly IUnitOfWork _uow;
        private readonly IPetSocialInteractionRepository _petSocialInteractionRepository;
        private readonly IMapper _mapper;
        public PetSocialInteractionService(IPetSocialInteractionRepository petSocialInteractionRepository,IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
            _petSocialInteractionRepository=petSocialInteractionRepository;
            _mapper=mapper;
            _uow=uow;
        }

        public async Task<IAppResult<PetSocialInteractionDTO>> AddSocialInteractionByPetId(int petid, int socialInteractionid)
        {
            var petSocialInteraction = await _petSocialInteractionRepository.AddSocialInteractionByPetId(petid, socialInteractionid);
            _uow.CommitAsync();
            var newResponse = _mapper.Map<PetSocialInteractionDTO>(petSocialInteraction);
            return AppResult<PetSocialInteractionDTO>.Success(StatusCodes.Status200OK, newResponse);
        }

        public async Task<IAppResult<List<PetWithSocialInteractionDTO>>> GetPetSocialInteractionByPetId(int petid)
        {
            var petSocialInteraction = await _petSocialInteractionRepository.GetPetSocialInteractionByPetId(petid);
            var petSocialInteractionDTOs = _mapper.Map<List<PetWithSocialInteractionDTO>>(petSocialInteraction);
            return AppResult<List<PetWithSocialInteractionDTO>>.Success(StatusCodes.Status200OK, petSocialInteractionDTOs);
        }
    }
}
