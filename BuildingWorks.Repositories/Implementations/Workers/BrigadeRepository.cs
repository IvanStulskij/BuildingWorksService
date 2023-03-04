using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Repositories.Abstractions.Workers;
using BuildingWorks.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementations.Workers
{
    public class BrigadeRepository : Repository<Brigade, int>, IBrigadeRepository
    {
        public BrigadeRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public IEnumerable<Brigade> GetObjectBrigades(int objectCode)
        {
            return _context.Brigades
                .Where(buildingObject => buildingObject.ObjectId == objectCode);
        }

        public IEnumerable<int> GetBrigadesCodes()
        {
            return Get().Select(brigade => brigade.Id);
        }
    }
}