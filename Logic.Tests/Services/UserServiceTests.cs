using Logic.Requests;
using Logic.Services;
using Logic.Tests.DatabaseUtils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;


namespace Logic.Tests.Services
{
    public class UserServiceTests
    {
        [Fact]
        public async Task RegisterUserAsyncTest()
        {

            using var context = new SqliteDbContext();
            var userService = new UserService(context);

            var newUser = new UserRegistrationRequest
            {
                Login = "Vlad",
                Password = "12345",
                Fullname = "Vladimir",
                Email = "myEmail@gmail.com",
                CountryId = 1

            };

            var userId = await userService.RegisterUserAsync(newUser);
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            Assert.NotNull(user);
            Assert.Equal(newUser.Login, user.Login);
            Assert.Equal(newUser.Fullname, user.Fullname);
            Assert.Equal(newUser.Email, user.Email);
            Assert.Equal(newUser.CountryId, user.CountryId);
        }


        [Fact]
        public async Task RegisterUserAsync_SameLoginFailure()
        {

            using var context = new SqliteDbContext();
            var userService = new UserService(context);

            var newUser1 = new UserRegistrationRequest
            {
                Login = "Vlad",
                Password = "12345",
                Fullname = "Vladimir",
                Email = "myEmail@gmail.com"
            };
            var request1 = await userService.RegisterUserAsync(newUser1);


            var newUser2 = new UserRegistrationRequest
            {
                Login = "Vlad",
                Password = "12345",
                Fullname = "Vladimir",
                Email = "myEmail@gmail.com"
            };

            await Assert.ThrowsAsync<Exception>(async () => await userService.RegisterUserAsync(newUser2));

        }

        [Fact]
        public async Task LoginUserAsyncTest()
        {
            using var context = new SqliteDbContext();
            var userService = new UserService(context);

            var newUser = new UserRegistrationRequest
            {
                Login = "Vlad",
                Password = "12345",
                Fullname = "Vladimir",
                Email = "myEmail@gmail.com"
            };
            await userService.RegisterUserAsync(newUser);

            var loginRequest = new UserLoginRequest
            {
                Login = newUser.Login,
                Password = newUser.Password
            };

            var tokenDto = await userService.LoginUserAsync(loginRequest);
           
            Assert.NotNull(tokenDto);
            Assert.Equal(loginRequest.Login, tokenDto.Login);
            Assert.NotNull(tokenDto.Token);
            Assert.NotEmpty(tokenDto.Token);
        }

        [Fact]
        public async Task LoginUserAsync_IncorrectLoginOrPasswordFailure()
        {
            using var context = new SqliteDbContext();
            var userService = new UserService(context);

            var loginRequest = new UserLoginRequest
            {
                Login = "test",
                Password = "12345"
            };

            await Assert.ThrowsAsync<Exception>(async () => await userService.LoginUserAsync(loginRequest));
        }


    }
}
