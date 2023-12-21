using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Core.DTOs
{
    public class FoodPetDTO
    {
        public int Id { get; set; }
        public List<string> FoodName { get; set; }
        public List<string> PetName { get; set; }
        //public List<DateTime> FoodDate { get; set; }
    }
}
