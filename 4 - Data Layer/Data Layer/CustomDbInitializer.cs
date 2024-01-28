using System.Data.Entity;

namespace Data_Layer
{
    public class CustomDbInitializer : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Users.Add(new User("Test User", "user@mail.com", "36EEF310DE82548DD1F0A23448DE8B55")); // "pass" + salt

            base.Seed(context);
        }
    }
}
