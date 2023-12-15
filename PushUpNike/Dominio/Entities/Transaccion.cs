using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Transaccion : BaseEntity
    {
        public double SubToTal {get; set;}
        public double ToTal {get; set;}
        public int IdProductoFk {get; set;}
        public Producto Producto {get; set;}
        public int IdClienteFk {get; set;}
        public Cliente Cliente {get; set;}

    }
}