using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Repositories;
using week4_huseyingulerman.Core.Result.Abstract;

namespace week4_huseyingulerman.Repository.Repositories
{
    public class PetRepository : GenericRepository<Pet>, IPetRepository
    {
        public PetRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Pet>> GetAllPetStatisticByPetId(int id)
        {
           

            return await _context.Pets.Include(x=>x.PetsFoods).ThenInclude(x=>x.Food).Include(x=>x.PetsActivities).ThenInclude(x=>x.Activity).Include(x=>x.Healths).Where(x=>x.Id==id).ToListAsync();
        }
        public async Task<List<Pet>> GetUserStatisticsByUserId(string userid)
        {

            return await _context.Pets.Include(x => x.AppUser).Include(x => x.Healths).Include(x=>x.PetsActivities).ThenInclude(x => x.Activity).Include(x => x.PetsFoods).ThenInclude(x => x.Food).AsNoTracking().Where(x => x.AppUserId == userid).ToListAsync();
        }
    }
}
