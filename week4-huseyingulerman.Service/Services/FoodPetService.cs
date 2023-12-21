using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Services;
using week4_huseyingulerman.Core.UnitOfWork;
using AutoMapper;
using week4_huseyingulerman.Core.Result.Abstract;
using Microsoft.AspNetCore.Http;
using week4_huseyingulerman.Core.Result.Concrete;
using week4_huseyingulerman.Core.Repositories;

namespace week4_huseyingulerman.Service.Services
{
    public class FoodPetService : Service<FoodPet, FoodPetCreateDTO, FoodPetDTO>, IFoodPetService
    {
        protected readonly IUnitOfWork _uow;
        private readonly IFoodPetRepository _foodPetRepository;
        private readonly IMapper _mapper;
        public FoodPetService(IFoodPetRepository foodPetRepository, IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
            _foodPetRepository=foodPetRepository;
            _mapper=mapper;
            _uow=uow;
        }

        public async Task<IAppResult<FoodPetDTO>> AddFoodByPetId(int petid, int foodid)
        {
            //var newEntity = _mapper.Map<Food>(foodCreateDTO);
            //await _foodRepository.AddFoodByPetId(newEntity);
            //await _uow.CommitAsync();
            //var newResponse = _mapper.Map<FoodDTO>(newEntity);
            var foodpet = await _foodPetRepository.AddFoodByPetId(petid, foodid);
            _uow.CommitAsync();
            var newResponse = _mapper.Map<FoodPetDTO>(foodpet);

            return AppResult<FoodPetDTO>.Success(StatusCodes.Status200OK, newResponse);
        }
    }
}
