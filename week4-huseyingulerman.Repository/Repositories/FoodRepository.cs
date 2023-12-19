using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Repositories;

namespace week4_huseyingulerman.Repository.Repositories
{
    public class FoodRepository : GenericRepository<Food>, IFoodRepository
    {
        public FoodRepository(AppDbContext context) : base(context)
        {
        }
        public async Task AddFoodByPetId(Food food)
        {
            await _context.Foods.AddAsync(food);
        }
    }
}
