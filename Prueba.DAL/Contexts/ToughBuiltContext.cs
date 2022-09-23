using System.Data.Entity;
using Prueba.Entity;

namespace Prueba.DAL.Contexts
{
    public partial class ToughBuiltContext : DbContext
    {
        public ToughBuiltContext()
            : base("name=DbConection")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.FeaturedCharacteristics)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.FeaturedImages)
                .IsUnicode(false);
        }
    }
}
