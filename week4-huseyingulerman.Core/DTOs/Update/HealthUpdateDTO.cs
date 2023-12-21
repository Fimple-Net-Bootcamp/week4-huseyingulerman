using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs.Create;

namespace week4_huseyingulerman.Core.DTOs.Update
{
    public class HealthUpdateDTO:HealthCreateDTO
    {
        public int Id { get; set; }
    }
}
