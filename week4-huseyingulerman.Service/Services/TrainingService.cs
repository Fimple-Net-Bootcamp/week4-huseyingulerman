using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Services;
using week4_huseyingulerman.Core.UnitOfWork;

namespace week4_huseyingulerman.Service.Services
{
    public class TrainingService : Service<Training, TrainingCreateDTO, TrainingDTO>, ITrainingService
    {
        public TrainingService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }
    }
}
