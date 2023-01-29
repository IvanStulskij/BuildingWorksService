﻿using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Provides;
using BuildingWorks.Models.Services.Interfaces.Providers;
using Models;
using Models.Repositories.Abstractions.Providers;
using Models.Resources.Providers;

namespace BuildingWorks.Models.Services.Implementations.Providers
{
    public class MaterialService :
        Service<Material, MaterialResource, MaterialForm>,
        IMaterialService
    {
        public MaterialService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IMaterialRepository Repository { get; }
    }
}