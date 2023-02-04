namespace Models.Interfaces
{
    public interface IPersistable<T>
    {
        T Id { get; set; }
    }
}
