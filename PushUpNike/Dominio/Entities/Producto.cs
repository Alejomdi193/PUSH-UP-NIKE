using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Producto : BaseEntity
    {
        public int Cantidad {get; set;}
        public string Nombre {get; set;}
        public byte[] Imagen {get; set;}
        public double Precio {get; set;}
        public int IdCategoriaFk {get; set;}
        public Categoria Categoria {get; set;} 
        public ICollection<Transaccion> Transacciones {get; set;}
    }
}