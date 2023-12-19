using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using week4_huseyingulerman.Core.Repositories;
using week4_huseyingulerman.Core.Result.Abstract;
using week4_huseyingulerman.Core.Result.Concrete;
using week4_huseyingulerman.Core.UnitOfWork;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Service.Services
{
    public class ActivityService: Service<Activity, ActivityCreateDTO, ActivityDTO>, IActivityService
    {
        protected readonly IUnitOfWork _uow;
        private readonly IActivityRepository _activityRepository;
        private readonly IMapper _mapper;
        public ActivityService(IUnitOfWork uow, IActivityRepository activityRepository, IMapper mapper) : base(uow, mapper)
        {
            _activityRepository=activityRepository;
            _mapper=mapper;
            _uow=uow;
        }

        public async Task<IAppResult<ActivityDTO>> AddActivityByPetId(ActivityCreateDTO activityCreateDTO)
        {
            var newEntity = _mapper.Map<Activity>(activityCreateDTO);
            await _activityRepository.AddActivityByPetId(newEntity);
            await _uow.CommitAsync();
            var newResponse = _mapper.Map<ActivityDTO>(newEntity);

            return AppResult<ActivityDTO>.Success(StatusCodes.Status200OK, newResponse);
        }

        public async Task<List<Activity>> GetActivityByPetId(int id)
        {
            var activity = await _activityRepository.GetActivityByPetId(id);

            return activity;
        }
    }
}
