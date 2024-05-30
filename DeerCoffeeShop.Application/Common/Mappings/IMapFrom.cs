using AutoMapper;

namespace DeerCoffeeShop.Application.Common.Mappings
{
    internal interface IMapFrom<T>
    {
        void Mapping(Profile profile);
    }
}
