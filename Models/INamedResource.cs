using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models
{
    public interface INamedResource : IResource
    {
        public string Name { get; set; }
    }
}
