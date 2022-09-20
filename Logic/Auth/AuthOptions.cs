using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Logic.Auth
{
    public class AuthOptions
    {

        public const string ISSUER = "WorldMoodServer";
        public const string AUDIENCE = "WorldMoodClient";
        const string KEY = "e73afb30637fe01677340ac6446a3c17d899fbe0cbc51841a57643230813a9c1";
        public const int LIFETIME = 24; // In hours
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }

    }
}
