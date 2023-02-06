﻿using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Workers;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Repositories.Abstractions.Workers;
using BuildingWorks.Services.Interfaces.Workers;

namespace BuildingWorks.Services.Implementations.Workers
{
    public class BrigadeService :
        Service<Brigade, BrigadeResource, BrigadeForm>,
        IBrigadeService
    {
        public BrigadeService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IBrigadeRepository Repository { get; }

        public IEnumerable<BrigadeResource> GetByObject(int objectId)
        {
            return Mapper.Map<IEnumerable<BrigadeResource>>(Repository.GetObjectBrigades(objectId));
        }

        public IEnumerable<int> GetBrigadesCodes()
        {
            return Repository.SelectBrigadesCodes();
        }
    }
}