using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Models.Profilers.Addresses
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
