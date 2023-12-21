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
    public class FoodPetRepository : GenericRepository<FoodPet>, IFoodPetRepository
    {
        public FoodPetRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<FoodPet> AddFoodByPetId(int petid, int foodid)
        {
            FoodPet foodPet = new FoodPet()
            {
                FoodId=foodid,
                PetId=petid
            };
            await _context.FoodsPets.AddAsync(foodPet);
            var data = _context.FoodsPets.Include(x => x.Pet).ThenInclude(x => x.Foods).FirstOrDefault(x => x.FoodId == foodPet.FoodId && x.PetId == foodPet.PetId);
            return data;
            //await _context.FoodsPets.AddAsync(foodPet);
            //return foodPet;
        }
    }
}
