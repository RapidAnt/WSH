using System;
using Data_Layer.Models;
using System.Data.Entity;

namespace Data_Layer
{
    public class CustomDbInitializer : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Users.Add(new User("Test User", "user@mail.com", "36EEF310DE82548DD1F0A23448DE8B55")); // "pass" + salt

            context.UserRates.Add(new UserRate(1, DateTime.Now, "1", "EUR", "386,13","Additional comment"));

            base.Seed(context);
        }
    }
}
