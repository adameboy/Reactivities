using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity{
                    Title ="Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    City = "London",
                    Venue = "Pub"   ,
                    Category = "drinks"
                },
                new Activity{
                    Title ="Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 months ago",
                     City = "Paris",
                    Venue = "Pub"   ,
                    Category = "dance"
                },
                new Activity{
                    Title ="Past Activity 3",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                     City = "London",
                    Venue = "Pub"   ,
                    Category = "drinks"
                }
            };
            await context.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }

    }
}