using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources.Workers
{
    public class BrigadeResource : BrigadeForm, IResource
    {
        public int Id { get; set; }
    }

    public class BrigadeForm
    {
        public int ObjectId { get; set; }

        public int BrigadierId { get; set; }
    }
}
