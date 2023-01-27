using BuildingWorks.Models.Databasable.Tables.Workers;
using Microsoft.EntityFrameworkCore;
using Models.Contexts;
using Models.Repositories.Abstractions.Workers;

namespace Models.Repositories.Implementations.Workers
{
    public class BrigadeRepository : Repository<Brigade, int>, IBrigadeRepository
    {
        public BrigadeRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public IEnumerable<Brigade> GetObjectBrigades(int objectCode)
        {
            return _context.Brigades.Include(brigade => brigade.Object)
                .Where(buildingObject => buildingObject.Object.ObjectId == objectCode);
        }

        public IEnumerable<int> SelectBrigadesCodes()
        {
            return Get().Select(brigade => brigade.BrigadeCode);
        }
    }
}