using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Core.DTOs.Create
{
    public class ActivityCreateDTO
    {
        public string Name { get; set; }
        public int PetId { get; set; }
        public bool IsActive { get; set; }
    }
}
