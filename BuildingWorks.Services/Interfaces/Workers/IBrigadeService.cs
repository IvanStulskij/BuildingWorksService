using BuildingWorks.Models.Resources.Workers;

namespace BuildingWorks.Services.Interfaces.Workers
{
    public interface IBrigadeService : IService<BrigadeResource, BrigadeForm>
    {
        IEnumerable<BrigadeResource> GetByObject(int objectCode);

        IEnumerable<int> GetCodes();
    }
}
