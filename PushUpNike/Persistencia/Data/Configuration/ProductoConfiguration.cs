using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(f => f.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(f => f.Cantidad)
                .IsRequired()
                .HasColumnName("Cantidad")
                .HasColumnType("double");

            builder.Property(f => f.Imagen)
                .IsRequired()
                .HasColumnName("Imagen")
                .HasColumnType("longblob");

            builder.Property(f => f.Precio)
                .IsRequired()
                .HasColumnName("Precio")
                .HasColumnType("double");

            builder.HasOne(p => p.Categoria)
            .WithMany(p => p.Productos)
            .HasForeignKey(p => p.IdCategoriaFk);

            
        }
    }
}