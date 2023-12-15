using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class TransaccionDto
    {
        public int Id {get; set;}
        public double SubToTal {get; set;}
        public double ToTal {get; set;}
    }
}