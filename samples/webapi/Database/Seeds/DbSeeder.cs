using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using webapi.Contexts;
using webapi.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace webapi.Seeds
{
    public static class DbSeeder
    {
        public static void Run(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                Seed(serviceScope.ServiceProvider.GetService<HeroContext>());
            }
        }

        public static void Seed(HeroContext context)
        {
            Console.WriteLine("Attempting to seed database");

            context.Database.Migrate();

            if (!context.Heroes.Any())
            {
                context.Heroes.AddRange(
                    new Hero { Name = "Nome 01" },
                    new Hero { Name = "Nome 02" },
                    new Hero { Name = "Nome 03" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Database already seeded");
            }
        }
    }
}
