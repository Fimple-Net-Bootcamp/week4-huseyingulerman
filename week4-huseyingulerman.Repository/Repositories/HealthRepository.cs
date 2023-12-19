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
    public class HealthRepository : GenericRepository<Health>, IHealthRepository
    {
        public HealthRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Health> GetHealtyByPetId(int id)
        {
            return await _context.Healths.Where(x => x.PetId == id).FirstOrDefaultAsync();
        }
    }
}
