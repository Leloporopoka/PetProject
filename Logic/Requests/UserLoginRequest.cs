using System.ComponentModel.DataAnnotations;

namespace Logic.Requests
{
    public class UserLoginRequest
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
