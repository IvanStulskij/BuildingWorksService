using BuildingWorks.Models.Databasable.Tables.Provides;
using Models.Contexts;

namespace Models.Repositories.Implementations.Providers
{
    internal class MaterialsRepository : Repository<Material, int>
    {
        public MaterialsRepository(BuildingWorksDbContext context) : base(context)
        {
        }
    }
}
