using Microsoft.EntityFrameworkCore;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using BuildingWorks.Models.Databasable.Tables.Plans;
using BuildingWorks.Models.Databasable.Tables.Provides;
using BuildingWorks.Models.Databasable.Tables.Registration;
using BuildingWorks.Models.Databasable.Tables.Workers;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BuildingWorks.Models.Databasable.Tables.Providers;

namespace BuildingWorksService
{
    public class BuildingWorksDbContext : DbContext, IDbContext
    {
        private readonly string _connectionString;

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ContractsByMaterials> ContractsByMaterials { get; set; }
        public DbSet<BuildingObject> BuildingObject { get; set; }
        public DbSet<ObjectAddress> ObjectAddress { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanDetail> PlansDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UnregisteredUserCode> UnregisteredUsersCodes { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Brigade> Brigades { get; set; }
        public DbSet<WorkerSalary> WorkersSalaries { get; set; }

        public BuildingWorksDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public BuildingWorksDbContext(DbContextOptions options) : base(options)
        {
        }

        public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
        {
            return Database.BeginTransactionAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.Parse("6.14"));
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brigade>(ConfigureBrigade);
            base.OnModelCreating(modelBuilder);
        }

        protected virtual void ConfigureBrigade(EntityTypeBuilder<Brigade> entity)
        {
            entity
                .HasOne(brigade => brigade.Brigadier)
                .WithOne(worker => worker.Brigade)
                .HasForeignKey<Brigade>(brigade => brigade.BrigadierId);
        }
    }

}