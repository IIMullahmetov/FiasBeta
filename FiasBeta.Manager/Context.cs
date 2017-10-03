using System.Data.Entity;

namespace FiasBeta.Entities
{
    public class Context : DbContext
    {

        public DbSet<AddressObject> Addresses { get; set; }
        public DbSet<House> Houses { get; set; }

        public Context() : base("Context")
        {
            Configuration.AutoDetectChangesEnabled = false;
        }
    }
}
