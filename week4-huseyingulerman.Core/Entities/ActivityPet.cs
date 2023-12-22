using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.Entities
{
    public class ActivityPet:BaseEntity
    {
        [ForeignKey("ActivityId")]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        [ForeignKey("PetId")]
        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}
