﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Core.Services
{
    public interface ITrainingService:IService<Training,TrainingCreateDTO,TrainingDTO>
    {
    }
}
