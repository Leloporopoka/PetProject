using Data.Models;
using Logic.Requests;
using Logic.Services;
using Logic.Tests.DatabaseUtils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace Logic.Tests.Services
{
    public class CountryMoodServiceTest
    {
        [Fact]
        public async Task AddCountryMoodAsyncTest()
        {
            using var context = new SqliteDbContext();
            var countryMoodService = new CountryMoodService(context);
            var addCountryMoodRequest = new AddCountryMoodRequest
            {
                UserId = 1,
                CountryId = 1,
                Mood = Moods.Bad
            };
            await context.Users.AddAsync(new User
            {
                Login = "Log",
                Email = "email",
                Fullname = "name",
                Password = "123",
                CountryId = 1,
            });

            await context.Countries.AddAsync(new Country
            {
                NameEn = "English",
                NameRu = "rus"

            });
            await context.SaveChangesAsync();
            var result = await countryMoodService.AddCountryMoodAsync(addCountryMoodRequest);
            Assert.True(result);


        }

        [Fact]


        public async Task CountryMoodAsyncUserHaveDifferentCountryIdTest()
        {
            using var context = new SqliteDbContext();
            var countryMoodService = new CountryMoodService(context);
            var addCountryMoodRequest = new AddCountryMoodRequest
            {
                UserId = 1,
                CountryId = 5,
                Mood = Moods.Bad
            };
            await context.Users.AddAsync(new User
            {
                Login = "Log",
                Email = "email",
                Fullname = "name",
                Password = "123",
                CountryId = 1,
            });

            await context.SaveChangesAsync();

            await Assert.ThrowsAsync<Exception>(async () => await countryMoodService.AddCountryMoodAsync(addCountryMoodRequest));



        }
        [Fact]

        public async Task CountryMoodAsyncUserHaveAlreadyLeftMoodTest()
        {
            using var context = new SqliteDbContext();
            var countryMoodService = new CountryMoodService(context);
            var addCountryMoodRequest = new AddCountryMoodRequest
            {
                UserId = 1,
                CountryId = 1,
                Mood = Moods.Bad
            };
            await context.Users.AddAsync(new User
            {
                Login = "Log",
                Email = "email",
                Fullname = "name",
                Password = "123",
                CountryId = 1,
            });

            await context.SaveChangesAsync();
            var result = await countryMoodService.AddCountryMoodAsync(addCountryMoodRequest);
            Assert.True(result);
            await Assert.ThrowsAsync<Exception>(async () => await countryMoodService.AddCountryMoodAsync(addCountryMoodRequest));



        }

        [Fact]
        public async Task CountryMoodAsync_MissingUserId()
        {
            var context = new SqliteDbContext();
            var countryMoodService = new CountryMoodService(context);
            var addCountryMoodRequest = new AddCountryMoodRequest
            {
                UserId = 1,
                CountryId = 1,
                Mood = Moods.Bad
            };


            await Assert.ThrowsAsync<Exception>(async () => await countryMoodService.AddCountryMoodAsync(addCountryMoodRequest));
        }
        [Fact]
        public async Task CountryMoodAsync_MissingCountryId()
        {
            var context = new SqliteDbContext();
            var countryMoodService = new CountryMoodService(context);
            var addCountryMoodRequest = new AddCountryMoodRequest
            {
                UserId = 1,
                CountryId = 1,
                Mood = Moods.Bad
            };
            await context.Users.AddAsync(new User
            {
                Login = "Log",
                Email = "email",
                Fullname = "name",
                Password = "123"
            });


            await Assert.ThrowsAsync<Exception>(async () => await countryMoodService.AddCountryMoodAsync(addCountryMoodRequest));
        }

        [Fact]
        public async Task GetAverageCountryMoodAsyncTest()
        {
            using var context = new SqliteDbContext();
            var countryMoodService = new CountryMoodService(context);

            context.Users.Add(new User
            {
                Login = "Log",
                Email = "email",
                Fullname = "name",
                Password = "123"
            });
            context.Users.Add(new User
            {
                Login = "Log1",
                Email = "email1",
                Fullname = "name1",
                Password = "123"
            });
            context.Users.Add(new User
            {
                Login = "Log2",
                Email = "email2",
                Fullname = "name2",
                Password = "123"
            });
            context.Users.Add(new User
            {
                Login = "Log3",
                Email = "email3",
                Fullname = "name3",
                Password = "123"
            });

            context.CountryMoods.Add(new CountryMood
            {
                UserId = 1,
                CountryId = 1,
                Mood = Moods.Horrible
            });
            context.CountryMoods.Add(new CountryMood
            {
                UserId = 2,
                CountryId = 1,
                Mood = Moods.Great
            });
            context.CountryMoods.Add(new CountryMood
            {
                UserId = 3,
                CountryId = 1,
                Mood = Moods.Normal
            });
            context.CountryMoods.Add(new CountryMood
            {
                UserId = 4,
                CountryId = 1,
                Mood = Moods.Normal
            });
            await context.SaveChangesAsync();

            var expectedValue = Moods.Normal;

            var resultAverage = await countryMoodService.GetAverageCountryMoodsAsync();
            Assert.NotNull(resultAverage);
            Assert.Equal(expectedValue, resultAverage.FirstOrDefault(r => r.CountryId == 1).Mood);
        }

    }
}
