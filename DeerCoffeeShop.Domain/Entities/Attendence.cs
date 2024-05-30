using DeerCoffeeShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeerCoffeeShop.Domain.Entities
{
    public class Attendence : Entity, ISoftDelete
    {
        public required string EmplpoyeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual required Employee Employee { get; set; }
        public required string EmployeeShiftID { get; set; }
        [ForeignKey("EmployeeShiftID")]
        public virtual required EmployeeShift EmployeeShift { get; set; }
        [DataType(DataType.ImageUrl)]
        public required string EmployeePictureUrl { get; set; }
        public DateTime? NgayXoa { get; set; }
        public string? NguoiXoaID { get; set; }
        [ForeignKey("NguoiXoaID")]
        public virtual Employee? NguoiXoa { get; set; }
        public bool IsDeleted { get; set; }
    }
}
