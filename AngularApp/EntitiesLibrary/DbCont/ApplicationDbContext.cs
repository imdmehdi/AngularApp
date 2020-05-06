using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Options;
using IdentityServer4.EntityFramework.Options;
using AutoMapper.Configuration.Conventions;
using Microsoft.Extensions.DependencyInjection;

namespace EntitiesLibrary.DbCont
{
    public class ApplicationDbContext : IDesignTimeDbContextFactory<DboContext>
    {
        public DboContext CreateDbContext(string[] args)
        {
            //IOptions<OperationalStoreOptions> operationalStoreOptions =OptionsBuilder(); 
            ////IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../MyCookingMaster.API/appsettings.json").Build();
            //var builder = new DbContextOptionsBuilder<DboContext>();
            //var connectionString = @"NLPULTP3403751\SQLEXPRESS;Database=AngularAppDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            //builder.UseSqlServer(connectionString);
            //return new DboContext(builder.Options, operationalStoreOptions);

            IServiceCollection services = new ServiceCollection();


            services.AddDbContext<DboContext>(options => options.UseSqlServer(@"NLPULTP3403751\SQLEXPRESS;Database=AngularAppDB;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.Configure<IdentityServer4.EntityFramework.Options.OperationalStoreOptions>(x => { });

            var context = services.BuildServiceProvider().GetService<DboContext>();

            return context;
        }
    }
}
