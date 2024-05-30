using AutoMapper;
using DeerCoffeeShop.Domain.Entities;

namespace DeerCoffeeShop.Application.Authentication
{
    public static class LoginDTOMappingExstensions
    {
        public static LoginDTO MapToLoginDTO(this Employee employee, IMapper mapper)
        => mapper.Map<LoginDTO>(employee);
    }
}
