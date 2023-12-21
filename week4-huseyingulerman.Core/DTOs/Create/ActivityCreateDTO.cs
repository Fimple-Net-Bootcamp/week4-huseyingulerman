using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Core.DTOs.Create
{
    public class ActivityCreateDTO
    {
        public string Name { get; set; }
        //public List<PetCreateDTO> Pets { get; set; }
        public bool IsActive { get; set; }
    }
}
