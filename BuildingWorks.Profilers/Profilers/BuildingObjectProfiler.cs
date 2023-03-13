using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.BuildingObject;

namespace BuildingWorks.Profilers.Profilers.BuildingObjects
{
    public class BuildingObjectProfiler : BaseOverviewProfiler<BuildingObject, BuildingObjectForm, BuildingObjectResource, BuildingObjectOverview>
    {
        protected override void ConfigureOverviewProfiling()
        {
            CreateMap<BuildingObject, BuildingObjectOverview>()
                .BeforeMap((src, dest) =>
                {
                    if (src.Town != null && src.Region != null && src.Street != null)
                    {
                        dest.Address = $"{src.Town.TownName} {src.Region.RegionName} {src.Street.StreetName}";
                    }

                    dest.Address = string.Empty;
                })
                .ForMember(x => x.Name, c => c.MapFrom(x => x.ObjectName))
                .ForMember(x => x.Customer, c => c.MapFrom(x => x.ObjectCustomer))
                .ForMember(x => x.Type, c => c.MapFrom(x => x.ObjectType));
        }
    }
}
