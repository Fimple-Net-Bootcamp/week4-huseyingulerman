using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.DTOs
{
    public class PetWithSocialInteractionDTO
    {
        public List<string> PetName { get; set; }
        public List<string> Species { get; set; }
        public List<string> SocialInteactionName { get; set; }
        public List<string> Place { get; set; }
    }
}
