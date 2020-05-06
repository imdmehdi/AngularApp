using EntitiesLibrary.DTO;
using Microsoft.EntityFrameworkCore;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.Extensions.Options;




namespace EntitiesLibrary.DbCont
{
    public class DboContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        //public DboContext(DbContextOptions<DboContext> options) : base(options) { }
        public DboContext(
           DbContextOptions<DboContext> options,
           IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<DTORegisterDetails> DTORegisterDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NLPULTP3403751\SQLEXPRESS;Database=AngularAppDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<DboContext>(new CreateDatabaseIfNotExists<DboContext>());
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
