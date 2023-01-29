using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Models.Resources.BuildingObject.Adress;

namespace BuildingWorks.Models.Profilers.Addresses
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
