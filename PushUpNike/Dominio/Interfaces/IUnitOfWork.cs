using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IUnitOfWork
    {
        IUser Users { get; }
        IRol Roles { get; }
        ICategoria Categorias {get;}
        ICliente Clientes {get;}
        IProducto Productos {get;}
        ITransaccion Transacciones {get;}
        Task<int> SaveAsync();

    }
}