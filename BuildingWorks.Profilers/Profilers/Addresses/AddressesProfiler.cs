using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using Models.Resources.BuildingObject.Addresses;

namespace BuildingWorks.Models.Profilers.Addresses
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
