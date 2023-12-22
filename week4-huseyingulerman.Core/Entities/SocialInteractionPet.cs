using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.Entities
{
    public class SocialInteractionPet:BaseEntity
    {
        [ForeignKey("PetId")]
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        [ForeignKey("SocialInteractionId")]
        public int SocialInteractionId { get; set; }
        public SocialInteraction SocialInteraction { get; set; }
    }
}
