using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EntitiesLibrary.DbCont
{
    public class ApplicationDbContext : IDesignTimeDbContextFactory<DboContext>
    {
        public DboContext CreateDbContext(string[] args)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../MyCookingMaster.API/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<DboContext>();
            var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=AngularAppDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            builder.UseSqlServer(connectionString);
            return new DboContext(builder.Options);
        }
    }
}
