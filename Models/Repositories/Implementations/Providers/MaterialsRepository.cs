using BuildingWorks.Models.Databasable.Tables.Provides;

namespace Models.Repositories.Implementations.Providers
{
    internal class MaterialsRepository : Repository<Material, int>
    {
        public MaterialsRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}
