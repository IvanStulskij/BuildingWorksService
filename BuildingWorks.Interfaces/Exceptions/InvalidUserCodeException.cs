namespace BuildingWorks.Common.Exceptions
{
    public class InvalidUserCodeException : Exception
    {
        public InvalidUserCodeException() : base("User code not exists in users codes collection")
        {

        }
    }
}