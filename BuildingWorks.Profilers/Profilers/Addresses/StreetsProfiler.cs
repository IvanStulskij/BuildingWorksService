using AutoMapper;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Profilers.Profilers.Addresses
{
    public class StreetsProfiler : Profile
    {
        public StreetsProfiler()
        {
            CreateMap<Street, StreetResource>().ReverseMap();
            CreateMap<Street, StreetForm>().ReverseMap();
        }
    }
}
