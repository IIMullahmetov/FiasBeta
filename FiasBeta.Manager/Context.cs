using FiasBeta.Manager;
using System.Data.Entity;

namespace FiasBeta.Entities
{
    public class Context : DbContext
    {

        public DbSet<AddressObject> Addresses { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<City> Sities { get; set; }
		public DbSet<Area> Areas { get; set; }
		public DbSet<Street> Streets { get; set; }
		public DbSet<Manager.House> Houses { get; set; }

        public Context() : base("Context")
        {
            Configuration.AutoDetectChangesEnabled = false;
        }
    }
}
