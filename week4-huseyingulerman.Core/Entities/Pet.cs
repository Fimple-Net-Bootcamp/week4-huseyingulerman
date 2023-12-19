using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.Entities
{
    public class Pet:BaseEntity
    {
        public string Name { get; set; }
        public string Species { get; set; }
        [ForeignKey("AppUserId")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public ICollection<Health> Healths { get; set; }
        public ICollection<Activity> Activities { get; set; }
        public ICollection<Food> Foods { get; set; }
        public Pet()
        {
            Healths=new HashSet<Health>();
            Activities=new HashSet<Activity>();
            Foods=new HashSet<Food>();
        }
    }
}
