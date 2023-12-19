using System;
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
using week4_huseyingulerman.Core.Repositories;
using week4_huseyingulerman.Core.Result.Abstract;
using week4_huseyingulerman.Core.Result.Concrete;
using week4_huseyingulerman.Core.UnitOfWork;

namespace week4_huseyingulerman.Service.Services
{
    public class FoodService : Service<Food, FoodCreateDTO, FoodDTO>, IFoodService
    {
        protected readonly IUnitOfWork _uow;
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;
        public FoodService(IFoodRepository foodRepository, IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
            _foodRepository=foodRepository;
            _mapper=mapper;
            _uow=uow;
        }

        public async Task<IAppResult<FoodDTO>> AddFoodByPetId(FoodCreateDTO foodCreateDTO)
        {
            var newEntity = _mapper.Map<Food>(foodCreateDTO);
            await _foodRepository.AddFoodByPetId(newEntity);
            await _uow.CommitAsync();
            var newResponse = _mapper.Map<FoodDTO>(newEntity);

            return AppResult<FoodDTO>.Success(StatusCodes.Status200OK, newResponse);
        }
    }
}
