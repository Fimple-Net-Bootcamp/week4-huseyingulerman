using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.Entities
{
    public class PetTraining:BaseEntity
    {
        [ForeignKey("PetId")]
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        [ForeignKey("TrainingId")]
        public int TrainingId { get; set; }
        public Training Training { get; set; }
    }
}
