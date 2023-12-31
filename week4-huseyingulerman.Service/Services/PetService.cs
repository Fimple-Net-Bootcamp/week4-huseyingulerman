﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using week4_huseyingulerman.Core.DTOs.Update;
using week4_huseyingulerman.Core.Repositories;
using week4_huseyingulerman.Core.Result.Abstract;
using week4_huseyingulerman.Core.Result.Concrete;
using week4_huseyingulerman.Core.UnitOfWork;

namespace week4_huseyingulerman.Service.Services
{
    public class PetService : Service<Pet, PetCreateDTO, PetDTO>, IPetService
    {
        private readonly IPetRepository _petRepository;
        private readonly IMapper _mapper;
        public PetService(IUnitOfWork uow, IMapper mapper, IPetRepository petRepository) : base(uow, mapper)
        {
            _petRepository=petRepository;
            _mapper=mapper;
        }

        public async Task<IAppResult<List<PetStatisticDTO>>> GetAllPetStatisticByPetId(int id)
        {
            var pet = await _petRepository.GetAllPetStatisticByPetId(id);
            var petStatisticDTOs = _mapper.Map<List<PetStatisticDTO>>(pet);
            return AppResult<List<PetStatisticDTO>>.Success(StatusCodes.Status200OK, petStatisticDTOs);
        }

        public async Task<IAppResult<List<UserStatisticDTO>>> GetUserStatisticsByUserId(string id)
        {
            //var pet = await _petRepository.GetAllPetStatisticByPetId(id);
            //var petStatisticDTOs = _mapper.Map<List<PetStatisticDTO>>(pet);
            //return AppResult<List<PetStatisticDTO>>.Success(StatusCodes.Status200OK, petStatisticDTOs);

            var user = await _petRepository.GetUserStatisticsByUserId(id);
            var userStatisticDTOs=_mapper.Map<List<UserStatisticDTO>>(user);
            return AppResult<List<UserStatisticDTO>>.Success(StatusCodes.Status200OK, userStatisticDTOs);
        }

        public async Task<IAppResult<NoContentDTO>> UpdatePetAsync(int id, PetUpdateDTO request)
        {
            var a = _mapper.Map<Pet>((await GetByIdAsync(id)).Data);
            a.Name=request.Name;
            a.AppUserId=request.AppUserId;
            a.Species=request.Species;
            a.IsActive=request.IsActive;
            _uow.GetRepository<Pet>().Update(a);
            _uow.CommitAsync();

            return AppResult<NoContentDTO>.Success(StatusCodes.Status204NoContent);
        }
    }
}
