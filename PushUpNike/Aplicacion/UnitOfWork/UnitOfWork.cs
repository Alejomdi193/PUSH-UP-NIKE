using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Repository;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PushContext context;
        private UserRepository _usuarios;
        private RolRepository _roles;
        private CategoriaRepository _categorias;
        private ProductoRepository _productos;
        private ClienteRepository _clientes;
        private TransaccionRepository _transacciones;

        public UnitOfWork(PushContext _context)
        {
            context = _context;
        }

        public IUser Users
        {
            get
            {
                if (_usuarios == null)
                {
                    _usuarios = new UserRepository(context);
                }
                return _usuarios;
            }
        }

        public IRol Roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RolRepository(context);
                }
                return _roles;
            }
        }


        public ITransaccion Transacciones
        {
            get
            {
                if (_transacciones == null)
                {
                    _transacciones = new TransaccionRepository(context);
                }
                return _transacciones;
            }
        }

        public ICliente Clientes
        {
            get
            {
                if (_clientes == null)
                {
                    _clientes = new ClienteRepository(context);
                }
                return _clientes;
            }
        }


        public IProducto Productos
        {
            get
            {
                if (_productos == null)
                {
                    _productos = new ProductoRepository(context);
                }
                return _productos;
            }
        }


        public ICategoria Categorias
        {
            get
            {
                if (_categorias == null)
                {
                    _categorias = new CategoriaRepository(context);
                }
                return _categorias;
            }
        }


        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }

        Task<int> IUnitOfWork.SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}