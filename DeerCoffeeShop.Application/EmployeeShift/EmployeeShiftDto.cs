using AutoMapper;
using DeerCoffeeShop.Application.Common.Mappings;
using DeerCoffeeShop.Domain.Entities;
using DeerCoffeeShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Application.EmployeeShift
{
    public class EmployeeShiftDto : IMapFrom<Domain.Entities.EmployeeShift>
    {
        public string? EmployeeID { get; set; }
        public string RestaurantID { get; set; }
        public int ShiftID { get; set; }
        public DateTime DateOfWork { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime? Actual_CheckIn { get; set; }
        public DateTime? Actual_CheckOut { get; set; }
        public DateTime? TotalHours { get; set; }
        public bool IsOnTime { get; set; } = false;
        public EmployeeShiftStatus Status { get; set; } = EmployeeShiftStatus.Absent;
        public int EmployeeNote { get; set; }
        public string? Note { get; set; }

        public EmployeeShiftDto()
        {
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.EmployeeShift, EmployeeShiftDto>();
        }

        public static EmployeeShiftDto Create(string? employeeID, string restaurantID, int shiftID
            , DateTime dateOfWork, int month, int year, DateTime checkIn, DateTime checkOut, DateTime? actual_CheckIn
            , DateTime? actual_CheckOut, DateTime? totalHours, bool isOnTime, EmployeeShiftStatus status
            , int employeeNote, string? note)
        {
            return new EmployeeShiftDto()
            {

                EmployeeID = employeeID,
                RestaurantID = restaurantID,
                ShiftID = shiftID,
                DateOfWork = dateOfWork,
                Month = month,
                Year = year,
                CheckIn = checkIn,
                CheckOut = checkOut,
                Actual_CheckIn = actual_CheckIn,
                Actual_CheckOut = actual_CheckOut,
                TotalHours = totalHours,
                IsOnTime = isOnTime,
                Status = status,
                EmployeeNote = employeeNote,
                Note = note,
            };
        }
    }
}
