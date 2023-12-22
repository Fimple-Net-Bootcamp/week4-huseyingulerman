using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Result.Abstract;

namespace week4_huseyingulerman.Core.Services
{
    public interface IUserService : IService<AppUser, UserCreateDTO, UserDTO>
    {
        Task<IAppResult<List<UserStatisticDTO>>> GetUserStatisticsByUserId(int id);
    }
}
