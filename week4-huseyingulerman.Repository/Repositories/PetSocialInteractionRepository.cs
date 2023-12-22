using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Repositories;

namespace week4_huseyingulerman.Repository.Repositories
{
    public class PetSocialInteractionRepository : GenericRepository<SocialInteractionPet>, IPetSocialInteractionRepository
    {
        public PetSocialInteractionRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<SocialInteractionPet> AddSocialInteractionByPetId(int petid, int socialinteractionid)
        {
            SocialInteractionPet petSocialInteraction = new SocialInteractionPet()
            {

                PetId = petid,
                SocialInteractionId = socialinteractionid
            };
            await _context.SocialInteractionPets.AddAsync(petSocialInteraction);
            return petSocialInteraction;
        }

        public async Task<List<SocialInteractionPet>> GetPetSocialInteractionByPetId(int petid)
        {
            return await _context.SocialInteractionPets.Include(x => x.Pet).Include(x => x.SocialInteraction).Where(x => x.PetId==petid).AsNoTracking().ToListAsync();
        }
    }
}
