using Prueba.Entity.Entities;
using System.Data.Entity;

namespace Prueba.Entity
{
    internal class ToughBuiltContext : DbContext
    {
        private const string connectionString = "Data Source=PREDATOR;Initial Catalog=ToughBuilt;Integrated Security=true";

        public ToughBuiltContext():base(connectionString)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
