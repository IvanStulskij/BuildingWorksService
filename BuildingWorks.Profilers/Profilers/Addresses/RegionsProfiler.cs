using AutoMapper;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Profilers.Profilers.Addresses
{
    public class RegionsProfiler : Profile
    {
        public RegionsProfiler()
        {
            CreateMap<Region, RegionResource>().ReverseMap();
            CreateMap<Region, RegionForm>().ReverseMap();
        }
    }
}
