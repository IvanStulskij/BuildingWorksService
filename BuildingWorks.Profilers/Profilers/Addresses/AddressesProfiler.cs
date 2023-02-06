using AutoMapper;
using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Profilers.Profilers.Addresses
{
    public class AddressesProfiler : Profile
    {
        public AddressesProfiler()
        {
            CreateMap<ObjectAddress, AddressResource>().ReverseMap();
            CreateMap<ObjectAddress, AddressForm>().ReverseMap();
        }
    }
}
