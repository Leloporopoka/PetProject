using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(256)]
        [Required]
        public string Login { get; set; }
        public string Password { get; set; }
        [MaxLength(256)]
        public string Fullname { get; set; }
        [MaxLength(128)]
        [EmailAddress]
        public string Email { get; set; }

        public long CountryId { get; set; }

    }
}
