using System.Data.Entity.Migrations;

namespace Data_Layer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Data_Layer.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data_Layer.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
