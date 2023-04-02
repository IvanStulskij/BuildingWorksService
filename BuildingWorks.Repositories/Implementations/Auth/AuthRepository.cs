using BuildingWorks.Common.Exceptions;
using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Registration;
using BuildingWorks.Models.Resources;
using BuildingWorks.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementations.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly BuildingWorksDbContext _context;

        public AuthRepository(BuildingWorksDbContext context)
        {
            _context = context;
        }

        public async Task<User> Authentificate(User user)
        {
            UnregisteredUserCode unregisteredCode =
                await _context.UnregisteredUsersCodes.FirstOrDefaultAsync(x => x.Id == user.Id);

            if (unregisteredCode == null)
            {
                throw new InvalidUserCodeException();
            }

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> Authorize(UserForm form)
        {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.FullName == form.FullName);

            if (user == null)
            {
                throw new EntityNotFoundException();
            }

            if (form.Password == user.Password)
            {
                return user;
            }

            throw new InvalidUserException();
        }
    }
}