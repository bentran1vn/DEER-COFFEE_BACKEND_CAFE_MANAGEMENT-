using AutoMapper;
using DeerCoffeeShop.Application.Common.Mappings;
using DeerCoffeeShop.Domain.Entities;

namespace DeerCoffeeShop.Application.Authentication
{

    public class LoginDTO : IMapFrom<Employee>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Employee, LoginDTO>();

        }
        public int Id { get; set; }
        public string RoleName { get; set; }
        public required string RefreshToken { get; set; }
        public static LoginDTO Create(int EmplopyeeID, string Role, string RefreshToken)
        {
            return new LoginDTO
            {
                Id = EmplopyeeID,
                RoleName = Role,
                RefreshToken = RefreshToken
            };
        }

    }
}
