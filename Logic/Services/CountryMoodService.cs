using Data.Database;
using Data.Models;
using Logic.Dtos;
using Logic.Interfaces;
using Logic.Requests;
using Microsoft.EntityFrameworkCore;

namespace Logic.Services
{
    public class CountryMoodService : ICountryMoodService
    {
        private readonly WorldMoodDbContext _dbContext;
        public CountryMoodService(WorldMoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddCountryMoodAsync(AddCountryMoodRequest request)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(i => i.Id == request.UserId);
            
            if (user == null)
            {
                throw new Exception($"User with id {request.UserId} not exists");
            }
            var country = await _dbContext.Countries.FirstOrDefaultAsync(c => c.Id == request.CountryId);
            if (request.CountryId != user.CountryId)
            {
                throw new Exception($"User with id {user.Id} doesn't belong to the country with Id {user.CountryId}");
            }
            if (country == null)
            {
                throw new Exception($"Country with id {request.CountryId} not exists");
            }

            var countryMoodCheck = await _dbContext.CountryMoods.FirstOrDefaultAsync(m => m.UserId == request.UserId);

            if (countryMoodCheck!=null )
            {
                throw new Exception($"User with id {request.UserId} already left his mood");
            }

            var countryMood = new CountryMood()
            {
                UserId = user.Id,
                CountryId = country.Id,
                Mood = request.Mood,
            };
          


            await _dbContext.CountryMoods.AddAsync(countryMood);
            await _dbContext.SaveChangesAsync();
            return true;

        }

        public async Task<List<CountryMoodDto>> GetAverageCountryMoodsAsync()
        {
            var countryMoodAverages = new List<CountryMoodDto>();
            var countries = await _dbContext.Countries.ToListAsync();

            if (countries is null)
            {
                throw new Exception($"The list of Countries is empty");
            }

            foreach (var country in countries)
            {
                var countryMoods = await _dbContext.CountryMoods.Where(c => country.Id == c.CountryId).ToListAsync();
                int average = 0;

                if (countryMoods?.Any() == true)
                {
                    average = (int)countryMoods.Average(c => (int)c.Mood);
                }
                else
                {
                    average = 3;
                }

                countryMoodAverages.Add(new CountryMoodDto
                {
                    CountryId = country.Id,
                    Mood = (Moods)average
                });

            }

            return countryMoodAverages;
        }
    }


}

