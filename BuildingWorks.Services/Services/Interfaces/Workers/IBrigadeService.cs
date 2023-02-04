using BuildingWorks.Models.Databasable.Tables.Workers;
using Models.Resources.Workers;

namespace BuildingWorks.Models.Services.Interfaces.Workers
{
    public interface IBrigadeService : IService<BrigadeResource, BrigadeForm>
    {
        IEnumerable<BrigadeResource> GetByObject(int objectCode);

        IEnumerable<int> GetBrigadesCodes();
    }
}
