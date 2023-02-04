namespace BuildingWorks.Common.Extensions
{
    public interface IPersistable<T>
    {
        T Id { get; set; }
    }
}
