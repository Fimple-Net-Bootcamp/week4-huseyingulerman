using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.Entities
{
    public class FoodPet:BaseEntity
    {
        [ForeignKey("FoodId")]
        public int FoodId { get; set; }
        public Food Food { get; set; }
        [ForeignKey("PetId")]
        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}
