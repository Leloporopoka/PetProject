using Data.Models;


namespace Logic.Dtos
{
    public class UserDto
    {

        public long Id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public string Fullname { get; set; }

        public string Email { get; set; }

        public long CountryId { get; set; }


        public UserDto(User model)
        {
            Id = model.Id;
            Login = model.Login;
            Password = model.Password;
            Fullname = model.Fullname;
            Email = model.Email;
            CountryId = model.CountryId;
        }

    }
}
