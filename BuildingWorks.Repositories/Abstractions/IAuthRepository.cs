using BuildingWorks.Databasable.Entities.Registration;
using BuildingWorks.Models.Resources;

namespace BuildingWorks.Repositories.Abstractions
{
    public interface IAuthRepository
    {
        Task<User> Authentificate(User form);

        Task<User> Authorize(UserForm form);
    }
}