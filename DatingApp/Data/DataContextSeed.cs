using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Entities;

namespace DatingApp.Data
{
    public class DataContextSeed
    {
        public static async Task SeedAsync(DataContext context)
        {
            if (context.Users.Any())
                return;
            List<AppUser> users = new List<AppUser>
            {
                new AppUser
                {
                    UserName = "Bob"
                },
                new AppUser
                {
                    UserName = "Ted"
                }
            };

            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();
        }
    }
}
