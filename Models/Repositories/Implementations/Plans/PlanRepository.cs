using BuildingWorks.Models.Databasable.Tables.Plans;
using Microsoft.EntityFrameworkCore;
using Models.Contexts;
using Models.Repositories.Abstractions.Plans;

namespace Models.Repositories.Implementations.Plans
{
    public sealed class PlanRepository : IPlanRepository
    {
        private readonly BuildingWorksDbContext _context;

        public PlanRepository(BuildingWorksDbContext context)
        {
            _context = context;
        }

        public void Delete(Plan entity)
        {
            _context.Remove(entity);

            _context.SaveChanges();
        }

        public IQueryable<Plan> Get()
        {
            return _context.Plans;
        }

        public async Task<Plan> GetById(int id)
        {
            return await _context.Plans.FirstOrDefaultAsync(plan => plan.Id == id);
        }

        public async Task<Plan> Insert(Plan entity)
        {
            await _context.Plans.AddAsync(entity);

            return entity;
        }

        public async Task Insert(IEnumerable<Plan> entities)
        {
            await _context.Plans.AddRangeAsync(entities);
        }

        public async Task<Plan> Update(Plan entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
