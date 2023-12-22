using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.Entities
{
    public class SocialInteraction:BaseEntity
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public ICollection<SocialInteractionPet> SocialInteractionPets { get; set; }
        public SocialInteraction()
        {
            SocialInteractionPets=new HashSet<SocialInteractionPet>();
        }
    }
}
