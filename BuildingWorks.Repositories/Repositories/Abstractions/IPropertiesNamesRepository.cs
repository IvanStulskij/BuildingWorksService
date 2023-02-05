namespace BuildingWorks.Repositories.Repositories.Abstractions
{
    public interface IPropertiesNamesRepository<T>
    {
        IEnumerable<string> GetPropertiesNames();
    }
}
