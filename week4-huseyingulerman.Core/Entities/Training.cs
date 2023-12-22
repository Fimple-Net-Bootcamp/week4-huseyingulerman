using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.Entities
{
    public class Training:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<PetTraining> TrainingsPets { get; set; }
        public Training()
        {
            TrainingsPets= new HashSet<PetTraining>();
        }
    }
}
