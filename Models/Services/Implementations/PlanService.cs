using AutoMapper;
using AutoMapper.QueryableExtensions;
using BuildingWorks.Models.Databasable;
using BuildingWorks.Models.Databasable.Tables.Plans;
using BuildingWorksService.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Contexts;
using Models.Extensions;
using Models.GlobalConstants;
using Models.Repositories.Abstractions.Plans;
using Models.Resources.Plans;

namespace Models.Services.Implementations
{
    public sealed class PlanService :
        Service<Plan, PlanResource>,
        IPlanService
    {
        public override IPlanRepository Repository { get; }

        public PlanService(
            IPlanRepository repository,
            BuildingWorksDbContext context,
            IMapper mapper
            ) : base(context, mapper)
        {
            Repository = repository;
        }

        public async Task<IEnumerable<PlanResource>> GetAll()
        {
            return await Repository.Get()
                .ProjectTo<PlanResource>(Mapper)
                .ToListAsync();
        }

        public override async Task<PlanResource> GetById(int id)
        {
            return Mapper.Map<PlanResource>(await Context.Plans.FirstOrDefaultAsync(plan => plan.PlanCode == id));
        }

        public async Task<PlanResource> Create(PlanForm planForm)
        {
            var planToInsert = Mapper.Map<Plan>(planForm);
            return Mapper.Map<PlanResource>(await Context.Plans.AddAsync(planToInsert));
        }

        public async Task<PlanResource> Update(int id, PlanForm planForm)
        {
            var plan = await Context.Plans.FirstAsync(plan => plan.Id == id);
            plan = Mapper.Map<Plan>(planForm);
            await Context.SaveChangesAsync();

            return Mapper.Map<PlanResource>(plan);
        }

        public async Task<IEnumerable<string>> GetPropertiesNames()
        {
            return Context.Plans
                .EntityType
                .GetProperties()
                .Select(property => property.Name);
        }

        public async Task<List<Plan>> GetByCondition(Condition condition)
        {
            var conditionalSelectQuery = new TemplateConditionalSelectQuery
                (
                    TablesNames.PlansName,
                    condition.PropertyName,
                    condition.CompatibleValue
                );

            return await Context
                .Plans
                .FromSqlRaw(conditionalSelectQuery.Query)
                .ToListAsync();
        }
    }
}