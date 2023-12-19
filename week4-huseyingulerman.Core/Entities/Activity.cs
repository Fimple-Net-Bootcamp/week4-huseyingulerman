using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.Entities
{
    public class Activity:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
        public Activity()
        {
            Pets=new HashSet<Pet>();
        }
    }
}
