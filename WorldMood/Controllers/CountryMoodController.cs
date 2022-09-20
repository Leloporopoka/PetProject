using Microsoft.AspNetCore.Mvc;
using Logic.Interfaces;
using Logic.Requests;
using Microsoft.AspNetCore.Authorization;
using Logic.Dtos;

namespace Application.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CountryMoodController
    {
        private readonly ICountryMoodService _countryMoodService;
        public CountryMoodController(ICountryMoodService countryMoodService)
        {
            _countryMoodService = countryMoodService;
        }
        [HttpPost("AddCountryMoodAsync")]
        public async Task<bool> AddCountryMoodAsync(AddCountryMoodRequest request)
        {
            return await _countryMoodService.AddCountryMoodAsync(request);
        }
        [HttpGet("AverageCountryMoodAsync")]
        public async Task<List<CountryMoodDto>> GetAverageCountryMoodsAsync()
        {
            return await _countryMoodService.GetAverageCountryMoodsAsync();
        }
    }
}
