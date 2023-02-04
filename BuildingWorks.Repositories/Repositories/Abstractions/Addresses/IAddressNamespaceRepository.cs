namespace Models.Repositories.Abstractions.Addresses
{
    public interface IAddressNamespaceRepository<T> : IRepository<T>
    {
        public T GetByName(string name);
    }
}
