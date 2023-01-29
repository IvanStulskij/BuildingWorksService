﻿using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Workers;
using BuildingWorks.Models.Services.Interfaces.Workers;
using Models;
using Models.Repositories.Abstractions.Workers;
using Models.Resources.Workers;

namespace BuildingWorks.Models.Services.Implementations.Workers
{
    public class BrigadeService :
        Service<Brigade, BrigadeResource, BrigadeForm>,
        IBrigadeService
    {
        public BrigadeService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IBrigadeRepository Repository { get; }

        public IEnumerable<Brigade> GetObjectBrigades(int objectCode)
        {
            return Repository.GetObjectBrigades(objectCode);
        }

        public IEnumerable<int> SelectBrigadesCodes()
        {
            return Repository.SelectBrigadesCodes();
        }
    }
}