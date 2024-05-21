using AutoMapper;

namespace DeerCoffeeShop.Application.Common.Mappings
{
    interface IMapFrom<T>
    {
        void Mapping(Profile profile);
    }
}
