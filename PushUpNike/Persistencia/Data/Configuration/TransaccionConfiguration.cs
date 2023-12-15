using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TransaccionConfiguration : IEntityTypeConfiguration<Transaccion>
    {
        public void Configure(EntityTypeBuilder<Transaccion> builder)
        {
            builder.Property(f => f.SubToTal)
                .IsRequired()
                .HasColumnName("Subtotal")
                .HasColumnType("double");

            builder.Property(f => f.ToTal)
                .IsRequired()
                .HasColumnName("Total")
                .HasColumnType("double");

            builder.HasOne(p => p.Producto)
            .WithMany(p => p.Transacciones)
            .HasForeignKey(p => p.IdProductoFk);

            builder.HasOne(p => p.Cliente)
            .WithMany(p => p.Transacciones)
            .HasForeignKey(p => p.IdClienteFk);
            


        }
    }
}