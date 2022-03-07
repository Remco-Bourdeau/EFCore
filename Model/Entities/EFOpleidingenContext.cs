using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Model.Entities
{
    class EFOpleidingenContext:DbContext
    {
        public static IConfigurationRoot configuration;
        public DbSet<Campus> Campussen { get; set; }
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<Land> Landen { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFOpleidingen;" +
            //    "Trusted_Connection=true;",
            //    options => options.MaxBatchSize(150));
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();
            var connectionString =
                configuration.GetConnectionString("EFOpleidingen");
            if (connectionString != null)
            {
                optionsBuilder.UseSqlServer(connectionString,
                    options => options.MaxBatchSize(150));
            }
        }
    }
}
