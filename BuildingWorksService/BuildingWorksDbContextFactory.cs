using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BuildingWorksService
{
    public class BuildingWorksDbContextFactory : IDesignTimeDbContextFactory<BuildingWorksDbContext>
    {
        private readonly string _connectionString;

        public BuildingWorksDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public BuildingWorksDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BuildingWorksDbContext>();
            optionsBuilder.UseMySql(_connectionString, ServerVersion.Parse("6.14"));

            return new BuildingWorksDbContext(optionsBuilder.Options);
        }
    }
}
