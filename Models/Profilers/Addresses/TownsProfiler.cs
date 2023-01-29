using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Models.Resources.BuildingObject.Adress;

namespace BuildingWorks.Models.Profilers.Addresses
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
