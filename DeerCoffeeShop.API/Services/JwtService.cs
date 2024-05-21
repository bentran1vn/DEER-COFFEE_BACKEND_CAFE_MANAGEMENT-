using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DeerCoffeeShop.API.Services
{
    public class JwtService
    {
        public class Token
        {
            public required string AccessToken { get; set; }
            public required string RefreshToken { get; set; }
        }
        public Token CreateToken(int ID, int roles, string refreshToken)
        {
            var claims = new List<Claim>
            {

                new(JwtRegisteredClaimNames.Sub, ID.ToString()),
                new(ClaimTypes.Role, roles.ToString())
            };



            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Deer Coffee Shop @PI 123abc456 anh iu em"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                // issuer: "test",
                // audience: "api",
                claims: claims,
                expires: DateTime.Now.AddYears(1),
                signingCredentials: creds);
            var re = new Token
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                RefreshToken = refreshToken
            };
            return re;
        }
    }
}
