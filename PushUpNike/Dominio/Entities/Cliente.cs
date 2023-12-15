using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nombre {get; set;} 
        public ICollection<Transaccion> Transacciones {get; set;}
    }
}