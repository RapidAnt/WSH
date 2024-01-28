using System.Data.Entity;

namespace Data_Layer
{
    public class CustomDbInitializer : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Users.Add(new User { UserName = "Test User", Email = "user@mail.com", Password = "pass" });

            base.Seed(context);
        }
    }
}
