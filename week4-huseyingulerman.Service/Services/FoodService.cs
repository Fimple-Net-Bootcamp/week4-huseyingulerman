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
      
        public FoodService( IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
          
        }

      
    }
}
