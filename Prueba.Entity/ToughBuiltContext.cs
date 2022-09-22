using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Prueba.Entity
{
    public partial class ToughBuiltContext : DbContext
    {
        public ToughBuiltContext()
            : base("name=ToughBuiltContext")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.featuredCharacteristics)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.feaaturedImages)
                .IsUnicode(false);
        }
    }
}
