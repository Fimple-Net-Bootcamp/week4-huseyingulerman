using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.DTOs
{
    public class PetWithTrainingDTO
    {
        public List<string> PetName { get; set; }
        public List<string> Species { get; set; }
        public List<string> TrainingName { get; set; }
        public List<decimal> Price { get; set; }
    }
}
