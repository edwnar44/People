using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using People.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace People.Domain.Context
{
    public class DataContext : DbContext
    {
        public DataContext(
            DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DetalleFactura>()
                .Property(df => df.ValorUnitario)
                .HasColumnType("decimal(18,2)");

            builder.Entity<DetalleFactura>()
            .HasOne(p => p.Factura)
            .WithMany(b => b.DetalleFacturas);

            base.OnModelCreating(builder);
        }
    }
}
