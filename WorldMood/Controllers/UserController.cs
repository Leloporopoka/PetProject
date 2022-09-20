using Logic.Dtos;
using Logic.Interfaces;
using Logic.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Application.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("GetUserModels")]
        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            return await _userService.GetAllUserAsync();
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<long> RegisterAsync(UserRegistrationRequest request)
        {
            return await _userService.RegisterUserAsync(request);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<AuthentificationDetailsDto> LoginAsync(UserLoginRequest request)
        {
            return await _userService.LoginUserAsync(request);
        }
    }
}

