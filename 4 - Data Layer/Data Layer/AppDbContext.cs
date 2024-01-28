using System.Data.Entity;

namespace Data_Layer
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext() : base("name=DbConnectionString")
        {
            Database.SetInitializer<AppDbContext>(new CustomDbInitializer());
        }
    }
}
