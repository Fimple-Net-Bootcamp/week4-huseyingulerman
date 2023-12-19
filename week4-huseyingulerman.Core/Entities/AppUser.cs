using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Enums;

namespace week4_huseyingulerman.Core.Entities
{
    public class AppUser:IdentityUser
    {
        public string FİrstName { get; set; }
        public string LastName { get; set; }

        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Pet> Pets { get; set; }
        public AppUser()
        {
            Pets=new HashSet<Pet>();
        }
    }
}
