﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Core.Repositories
{
    public interface IFoodRepository:IGenericRepository<Food>
    {
        Task AddFoodByPetId(Food food);
    }
}
