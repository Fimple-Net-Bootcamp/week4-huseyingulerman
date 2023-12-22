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
    public class UserRepository : GenericRepository<AppUser>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<AppUser> GetUserStatisticsByUserId(string userid)
        {

            //return await _context.Pets.Include(x => x.PetsFoods).ThenInclude(x => x.Food).Include(x => x.PetsActivities).ThenInclude(x => x.Activity).Include(x => x.Healths).Where(x => x.Id==id).ToListAsync();
            return await _context.AppUsers.Include(x => x.Pets).Include(x => x.Pets).ThenInclude(x => x.Healths).Include(x => x.Pets).ThenInclude(x => x.PetsActivities).ThenInclude(x => x.Activity).Include(x => x.Pets).ThenInclude(x => x.PetsFoods).ThenInclude(x => x.Food).AsNoTracking().FirstOrDefaultAsync(x => x.Id == userid);
        }
    }
}
