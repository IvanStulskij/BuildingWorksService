using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.Workers
{
    public class BrigadeResource : BrigadeForm, IResource
    {
        public int Id { get; set; }
    }

    public class BrigadeForm
    {
        public string BuildingObject { get; set; }

        public string Brigadier { get; set; }
    }
}
