﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Result.Abstract;

namespace week4_huseyingulerman.Core.Repositories
{
    public interface IPetRepository:IGenericRepository<Pet>
    {
        Task<List<Pet>> GetAllPetStatisticByPetId(int id);
        Task<List<Pet>> GetUserStatisticsByUserId(string userid);
    }
}
