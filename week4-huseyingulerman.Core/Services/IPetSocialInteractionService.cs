using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Repositories;
using week4_huseyingulerman.Core.Result.Abstract;

namespace week4_huseyingulerman.Core.Services
{
    public interface IPetSocialInteractionService:IService<SocialInteractionPet,PetSocialInteractionCreateDTO,PetSocialInteractionDTO>
    {
        Task<IAppResult<PetSocialInteractionDTO>> AddSocialInteractionByPetId(int petid, int socialInteractionid);
        Task<IAppResult<List<PetWithSocialInteractionDTO>>> GetPetSocialInteractionByPetId(int petid);
    }
}
