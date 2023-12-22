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
    public class ActivityRepository : GenericRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(AppDbContext context) : base(context)
        {
        }
        public async Task AddActivityByPetId(Activity activity)
        {
            await _context.Activities.AddAsync(activity);
        }

        public async Task<List<Activity>> GetActivityByPetId(int id)
        {
            var a= await _context.Activities.Include(x => x.ActivitiesPets).ThenInclude(x=>x.Pet).Where(x => x.Id == id).ToListAsync();
            return a;

        }
    }
}
