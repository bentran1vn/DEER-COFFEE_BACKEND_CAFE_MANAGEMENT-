using AutoMapper;
using DeerCoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Authentication
{
    public static class LoginDTOMappingExstensions
    {
        public static LoginDTO MapToLoginDTO(this Employee employee, IMapper mapper)
        => mapper.Map<LoginDTO>(employee);
    }
}
