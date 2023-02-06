using AutoMapper;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Profilers.Profilers.Addresses
{
    public class TownsProfiler : Profile
    {
        public TownsProfiler()
        {
            CreateMap<Town, TownResource>().ReverseMap();
            CreateMap<Town, TownForm>().ReverseMap();
        }
    }
}
