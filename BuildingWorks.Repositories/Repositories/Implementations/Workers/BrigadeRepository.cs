using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Repositories.Implementations;
using BuildingWorks.Repositories.Repositories.Abstractions.Workers;
using Microsoft.EntityFrameworkCore;

namespace Models.Repositories.Implementations.Workers
{
    public class BrigadeRepository : Repository<Brigade, int>, IBrigadeRepository
    {
        public BrigadeRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<Brigade> GetById(int id)
        {
            return await _context.Brigades.FirstOrDefaultAsync(brigade => brigade.Id == id);
        }

        public IEnumerable<Brigade> GetObjectBrigades(int objectCode)
        {
            return _context.Brigades
                .Where(buildingObject => buildingObject.ObjectId == objectCode);
        }

        public IEnumerable<int> SelectBrigadesCodes()
        {
            return Get().Select(brigade => brigade.Id);
        }
    }
}