using AutoMapper;
using DeerCoffeeShop.Application.Common.Mappings;
using DeerCoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Authentication
{

    public class LoginDTO : IMapFrom<Employee>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Employee, LoginDTO>();

        }
        public int Id { get; set; }
        public int RoleId { get; set; }
        public static LoginDTO Create(int EmplopyeeID, int Role)
        {
            return new LoginDTO
            {
                Id = EmplopyeeID,
                RoleId = Role
            };
        }

    }
}
