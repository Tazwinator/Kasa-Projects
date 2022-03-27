using Microsoft.EntityFrameworkCore;
using TMDb.DataAccess.Data;
using TMDb.DataAccess.Entities;

namespace TMDb.AppDataAPI
{
    public class SeedDb
    {

        public static void Seed(string defaultConnString)
        {

            var services = new ServiceCollection();
            var serviceProvider = services.BuildServiceProvider();
            services.AddLogging();
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(defaultConnString)
            );

            using ( var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {

                var DbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();
                DbContext.Database.Migrate();

                Movie test = new Movie() { Title = "You're Mum" };

                DbContext.Movies.Add(test);
                DbContext.SaveChanges();
            }

           
        }

    }
}
