using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository
{
    public class TransaccionRepository : Generic<Transaccion>, ITransaccion
    {
        public readonly PushContext _context;
        public TransaccionRepository(PushContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Transaccion>> GetAllAsync()
        {
            return await _context.Transacciones
                .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<Transaccion> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
        {
            var query = _context.Transacciones.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Id.ToString().ToLower().Contains(search));
            }

            query = query.OrderBy(p => p.Id);
            var totalRegistros = await query.CountAsync();
            var registros = await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (totalRegistros, registros);
        }
    }
}