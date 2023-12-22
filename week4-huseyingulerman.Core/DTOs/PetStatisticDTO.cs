using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.DTOs
{
    public class PetStatisticDTO
    {
        public string PetName { get; set; }
        public List<string> ActivityName { get; set; }
        public List<string> FoodName { get; set; }
        public List<string> HealthName { get; set; }
    }
}
