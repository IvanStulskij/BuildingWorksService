namespace BuildingWorks.Repositories.Abstractions
{
    public interface IPropertiesNamesRepository<T>
    {
        IEnumerable<string> GetPropertiesNames();
    }
}
