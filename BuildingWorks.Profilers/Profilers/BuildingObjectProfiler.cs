using AutoMapper;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Resources.BuildingObject;

namespace BuildingWorks.Profilers.Profilers.BuildingObjects
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
