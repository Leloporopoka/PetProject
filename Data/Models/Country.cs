using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Country
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string NameRu { get; set; }
        [Required]
        [MaxLength(256)]
        public string NameEn { get; set; }

        public Country(long id, string nameEn, string nameRu)
        {
            Id = id;
            NameEn = nameEn;
            NameRu = nameRu;
        }
        public Country()
        {
         
        }
    }
}
