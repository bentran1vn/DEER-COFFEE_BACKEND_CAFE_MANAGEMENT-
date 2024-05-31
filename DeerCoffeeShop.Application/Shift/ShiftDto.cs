using AutoMapper;
using DeerCoffeeShop.Application.Common.Mappings;
using DeerCoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.Shift
{
    public class ShiftDto : IMapFrom<Domain.Entities.Shift>
    {
        public ShiftDto() { }

        public string name { get; set; }

        public DateTime ShiftStart { get; set; }

        public DateTime ShiftEnd { get; set; }

        public string ShiftDescription { get; set; }

        public bool IsActive { get; set; }

        public static ShiftDto Create(string name, DateTime shiftStart, DateTime shiftEnd
            , string shiftDescription, bool isActive)
        {
            return new ShiftDto()
            {
                name = name,
                ShiftStart = shiftStart,
                ShiftEnd = shiftEnd,
                ShiftDescription = shiftDescription,
                IsActive = isActive
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Shift, ShiftDto>();
        }
    }
}
