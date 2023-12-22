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
    public class PetTrainingRepository : GenericRepository<PetTraining>, IPetTrainingRepository
    {
        public PetTrainingRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<PetTraining> AddTrainingByPetId(int petid, int trainingid)
        {
            PetTraining petTraining = new PetTraining()
            {
                
             PetId = petid,
             TrainingId = trainingid
            };
            await _context.PetTrainings.AddAsync(petTraining);
            return petTraining;
        }

        public async Task<List<PetTraining>> GetPetTrainingByPetId(int petid)
        {
            return await _context.PetTrainings.Include(x => x.Pet).Include(x=>x.Training).Where(x => x.PetId==petid).AsNoTracking().ToListAsync();
        }
    }
}
