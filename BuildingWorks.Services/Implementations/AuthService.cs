using AutoMapper;
using BuildingWorks.Databasable.Entities.Registration;
using BuildingWorks.Models.Resources;
using BuildingWorks.Repositories.Abstractions;
using BuildingWorks.Services.Interfaces;

namespace BuildingWorks.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        private readonly IMapper _mapper;

        public AuthService(IAuthRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UserResource> Authentificate(UserForm form)
        {
            User user = await _repository.Authentificate(_mapper.Map<User>(form));

            return _mapper.Map<UserResource>(user);
        }

        public async Task<UserResource> Authorize(UserForm form)
        {
            User user = await _repository.Authorize(form);

            return _mapper.Map<UserResource>(user);
        }
    }
}
