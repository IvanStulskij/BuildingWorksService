﻿using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.Providers;
using Models.Resources.Providers;

namespace BuildingWorks.Models.Profilers
{
    public class ContractsProfiler : Profile
    {
        public ContractsProfiler()
        {
            CreateMap<Contract, ContractForm>().ReverseMap();
            CreateMap<Contract, ContractResource>().ReverseMap();
        }
    }
}