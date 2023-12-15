using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class ProductoDto
    {
        public int Id {get; set;}
        public int Cantidad {get; set;}
        public string Nombre {get; set;}
        public byte[] Imagen {get; set;}
        public double Precio {get; set;}
    }
}