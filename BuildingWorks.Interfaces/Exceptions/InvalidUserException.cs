namespace BuildingWorks.Common.Exceptions
{
    public class InvalidUserException : Exception
    {
        public InvalidUserException() : base("User password is uncorrect, please, check credentials")
        {

        }
    }
}