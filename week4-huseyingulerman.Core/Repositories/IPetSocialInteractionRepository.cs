using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Core.Repositories
{
    public interface IPetSocialInteractionRepository:IGenericRepository<SocialInteractionPet>
    {
        Task<SocialInteractionPet> AddSocialInteractionByPetId(int petid, int socialinteractionid);
        Task<List<SocialInteractionPet>> GetPetSocialInteractionByPetId(int petid);
    }
}
