using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Core.Repositories
{
    public interface IActivityRepository : IGenericRepository<Activity>
    {
        Task AddActivityByPetId(Activity activity);
        Task<List<Activity>> GetActivityByPetId(int id);
    }
}
