using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using Models.Resources.BuildingObject;

namespace BuildingWorks.Models.Profilers
{
    public class BuildingObjectProfiler : Profile
    {
        public BuildingObjectProfiler()
        {
            CreateMap<BuildingObject, BuildingObjectResource>().ReverseMap();
            CreateMap<BuildingObject, BuildingObjectForm>().ReverseMap();
        }
    }
}
