﻿using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.Repositories.Abstractions.Plans;
using BuildingWorks.Services.Bases;
using BuildingWorks.Services.Interfaces.Plans;

namespace BuildingWorks.Services.Implementations.Plans
{
    public class PlanService :
        ConditionalOverviewService<Plan, PlanResource, PlanForm, PlanOverview>,
        IPlanService
    {
        public PlanService(BuildingWorksDbContext context, IMapper mapper, IPlanRepository repository) : base(context, mapper, repository)
        {
            Repository = repository;
        }

        public override IPlanRepository Repository { get; }

        public async Task<IEnumerable<string>> GetPropertiesNames()
        {
            return Context.Plans
                .EntityType
                .GetProperties()
                .Select(property => property.Name);
        }
    }
}