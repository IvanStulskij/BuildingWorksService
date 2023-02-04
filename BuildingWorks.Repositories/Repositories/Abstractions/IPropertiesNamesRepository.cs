namespace Models.Repositories.Abstractions
{
    public interface IPropertiesNamesRepository<T>
    {
        IEnumerable<string> GetPropertiesNames();
    }
}
