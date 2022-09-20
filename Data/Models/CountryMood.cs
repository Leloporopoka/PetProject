
namespace Data.Models
{
    public class CountryMood
    {
        
        public long Id { get; set; }
        public long CountryId { get; set; }

        public long UserId { get; set; }
        public Moods Mood { get; set; }


    }
    public enum Moods
    {
        Horrible = 1,

        Bad = 2,

        Normal = 3,

        Good = 4,

        Great = 5,
    }
}
