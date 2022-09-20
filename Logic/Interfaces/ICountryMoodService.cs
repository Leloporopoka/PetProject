using Logic.Dtos;
using Logic.Requests;



namespace Logic.Interfaces
{
    public interface ICountryMoodService

    {
        public Task<bool> AddCountryMoodAsync(AddCountryMoodRequest request);
        public Task<List<CountryMoodDto>> GetAverageCountryMoodsAsync();
    }
}
