using DeerCoffeeShop.Domain.Entities.Base;
using DeerCoffeeShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Domain.Entities
{
    public class EmployeeShift : Entity, ISoftDelete
    {
        public string? EmployeeID { get; set; }
        [ForeignKey("ID")]
        public virtual Employee? Employee { get; set; }
        public required string RestaurantID { get; set; }
        [ForeignKey("RestaurantID")]
        public virtual required Restaurant Restaurant { get; set; }
        public required int ShiftID { get; set; }
        [ForeignKey("ShiftID")]
        public virtual required Shift Shift { get; set; }
        [DataType(DataType.Date)]
        public required DateTime DateOfWork { get; set; }
        public required int Month { get; set; }
        public required int Year { get; set; }
        [DataType(DataType.Time)]
        public required DateTime CheckIn { get; set; }
        [DataType(DataType.Time)]
        public required DateTime CheckOut { get; set; }
        [DataType(DataType.Time)]
        public DateTime? Actual_CheckIn { get; set; }
        [DataType(DataType.Time)]
        public DateTime? Actual_CheckOut { get; set; }
        [DataType(DataType.Time)]
        public DateTime? TotalHours { get; set; }
        public required bool IsOnTime { get; set; } = false;
        public required EmployeeShiftStatus Status { get; set; } = EmployeeShiftStatus.Absent;
        public int EmployeeNote { get; set; }
        public string? Note { get; set; }
        public bool IsEmpty { get; set; } = true;
        public DateTime? NgayXoa { get; set; }
        public string? NguoiXoaID { get; set; }
        [ForeignKey("NguoiXoaID")]
        public virtual Employee? NguoiXoa { get; set; }
        public bool IsDeleted { get; set; }
    }
}
