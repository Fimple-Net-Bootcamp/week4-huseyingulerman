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
        public ICollection<ActivityPet> ActivitiesPets { get; set; }
        public Activity()
        {
            ActivitiesPets=new HashSet<ActivityPet>();
        }
    }
}
