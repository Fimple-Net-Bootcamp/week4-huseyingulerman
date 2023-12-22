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
    public class PetTrainingService : Service<PetTraining, PetTrainingCreateDTO, PetTrainingDTO>, IPetTrainingService
    {
        protected readonly IUnitOfWork _uow;
        private readonly IPetTrainingRepository _petTrainingRepository;
        private readonly IMapper _mapper;
        public PetTrainingService(IPetTrainingRepository petTrainingRepository, IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
            _petTrainingRepository=petTrainingRepository;
            _mapper=mapper;
            _uow=uow;
        }

        public async Task<IAppResult<PetTrainingDTO>> AddTrainingByPetId(int petid, int trainingid)
        {
            var petTraining = await _petTrainingRepository.AddTrainingByPetId(petid,trainingid);
            _uow.CommitAsync();
            var newResponse = _mapper.Map<PetTrainingDTO>(petTraining);
            return AppResult<PetTrainingDTO>.Success(StatusCodes.Status200OK, newResponse);
        }

        public async Task<IAppResult<List<PetWithTrainingDTO>>> GetPetTrainingByPetId(int petid)
        {
            var petTraining = await _petTrainingRepository.GetPetTrainingByPetId(petid);
            var petTrainingDTOs = _mapper.Map<List<PetWithTrainingDTO>>(petTraining);
            return AppResult<List<PetWithTrainingDTO>>.Success(StatusCodes.Status200OK, petTrainingDTOs);
        }
    }
}
