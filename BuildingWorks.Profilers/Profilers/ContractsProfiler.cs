using AutoMapper;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.Profilers.Profilers.Contracts
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
