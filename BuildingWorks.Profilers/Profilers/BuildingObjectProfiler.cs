using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.BuildingObject;

namespace BuildingWorks.Profilers.Profilers.BuildingObjects
{
    public class BuildingObjectProfiler : Profile
    {
        public BuildingObjectProfiler()
        {
            CreateMap<BuildingObject, BuildingObjectResource>().ReverseMap();
            CreateMap<BuildingObject, BuildingObjectForm>().ReverseMap();
            CreateMap<BuildingObject, BuildingObjectOverview>()
                .ForMember(x => x.Name, c => c.MapFrom(x => x.ObjectName))
                .ForMember(x => x.Customer, c => c.MapFrom(x => x.ObjectCustomer))
                .ForMember(x => x.Address, c => c.MapFrom(x => $"{x.Town.TownName} {x.Region.RegionName} {x.Street.StreetName}"))
                .ForMember(x => x.Type, c => c.MapFrom(x => x.ObjectType));
        }
    }
}
