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
        public ICollection<ActivityPet> PetsActivities { get; set; }
        public ICollection<FoodPet> PetsFoods { get; set; }
        public ICollection<PetTraining> PetsTrainings { get; set; }
        public ICollection<SocialInteractionPet> PetsSocialInteraction { get; set; }
        public Pet()
        {
            PetsSocialInteraction=new HashSet<SocialInteractionPet>();
            Healths =new HashSet<Health>();
            PetsActivities=new HashSet<ActivityPet>();
            PetsFoods=new HashSet<FoodPet>();
            PetsTrainings=new HashSet<PetTraining>();
        }
    }
}
