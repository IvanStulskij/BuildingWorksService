using BuildingWorks.Common.Extensions;

namespace BuildingWorks.Models.Resources
{
    public class UserResource : UserForm, IResource
    {
        public int Id { get; set; }
    }

    public class UserForm
    {
        public string FullName { get; set; }

        public string Password { get; set; }
    }
}
