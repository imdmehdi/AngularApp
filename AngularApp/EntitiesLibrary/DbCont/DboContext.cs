using EntitiesLibrary.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;


namespace EntitiesLibrary.DbCont
{
    public class DboContext: DbContext
    {
        public DboContext(DbContextOptions<DboContext> options) : base(options) { }
        public DbSet<DTORegisterDetails> DTORegisterDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AngularAppDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<DboContext>(new CreateDatabaseIfNotExists<DboContext>());
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
