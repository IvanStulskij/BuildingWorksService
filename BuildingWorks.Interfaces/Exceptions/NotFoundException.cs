namespace BuildingWorks.Common.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException() : base ("The entity doesn't exist")
        { }
    }
}
