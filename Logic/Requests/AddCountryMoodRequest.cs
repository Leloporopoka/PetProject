using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Requests
{
    public class AddCountryMoodRequest
    {
        public long CountryId { get; set; }

        public long UserId { get; set; }
        public Moods Mood { get; set; }
    }
}
