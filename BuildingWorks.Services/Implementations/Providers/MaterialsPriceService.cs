﻿using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Repositories.Abstractions.Providers;
using BuildingWorks.Services.Interfaces.Providers;

namespace BuildingWorks.Services.Implementations.Providers
{
    public class MaterialsPriceService : Service<ContractsByMaterials, MaterialsPriceResource, MaterialsPriceForm>,
        IMaterialsPriceService
    {
        public MaterialsPriceService(BuildingWorksDbContext context, Mapper mapper) : base(context, mapper)
        {
        }

        public override IMaterialPriceRepository Repository { get; }

        public float GetByObject(int objectId)
        {
            return Repository.GetMaterialsPrice(objectId);
        }

        public IEnumerable<MaterialsPriceForm> GetMaterialsContracts(int objectId)
        {
            return Mapper.Map<IEnumerable<MaterialsPriceForm>>(Repository.GetMaterialsContracts(objectId));
        }
    }
}
