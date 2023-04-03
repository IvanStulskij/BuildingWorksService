using BuildingWorks.Models.Resources;

namespace BuildingWorks.Services.Interfaces
{
    public interface IAuthService
    {
        Task<UserResource> Authentificate(UserForm form);

        Task<UserResource> Authorize(UserForm user);
    }
}