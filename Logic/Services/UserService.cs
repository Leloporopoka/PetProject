using Data.Database;
using Data.Models;
using Logic.Auth;
using Logic.Dtos;
using Logic.Interfaces;
using Logic.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Logic.Services
{
    public class UserService : IUserService
    {

        private readonly WorldMoodDbContext _dbContext;
        public UserService(WorldMoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<UserDto>> GetAllUserAsync()
        {
            var user = await _dbContext.Users.ToListAsync();
            return user.Select(x => new UserDto(x)).ToList();
        }
        public static string Sha256Hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        public async Task LoginCheck(string login)
        {

            var loginExist = await _dbContext.Users.AnyAsync(u => u.Login == login);

            if (loginExist)
            {
                throw new Exception($"Login {login} already exist");
            }

        }

        public async Task<long> RegisterUserAsync(UserRegistrationRequest request)
        {

            await LoginCheck(request.Login);

            var user = new User()
            {
                Login = request.Login,
                Password = Sha256Hash(request.Password),
                Fullname = request.Fullname,
                Email = request.Email,
                CountryId = request.CountryId  
            };

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user.Id;

        }

        public async Task<AuthentificationDetailsDto> LoginUserAsync(UserLoginRequest request)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Login == request.Login && u.Password == Sha256Hash(request.Password));
            
            if(user is null)
            {
                throw new Exception($"Incorrect login or password");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login)
            };

            var date = DateTime.UtcNow;

            var jwt = new JwtSecurityToken(
                   issuer: AuthOptions.ISSUER,
                   audience: AuthOptions.AUDIENCE,
                   notBefore: date,
                   claims: claims,
                   expires: date.Add(TimeSpan.FromHours(AuthOptions.LIFETIME)),
                   signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return new AuthentificationDetailsDto 
            { 
                Login = user.Login,
                Token = encodedJwt
            };
        }
    }
}


