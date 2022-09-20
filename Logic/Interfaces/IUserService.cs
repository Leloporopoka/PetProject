using Logic.Dtos;
using Logic.Requests;

namespace Logic.Interfaces
{
    public interface IUserService
    {
        public Task<IEnumerable<UserDto>> GetAllUserAsync();
        public Task<long> RegisterUserAsync(UserRegistrationRequest request);
        public Task<AuthentificationDetailsDto> LoginUserAsync(UserLoginRequest request);
    }
}
