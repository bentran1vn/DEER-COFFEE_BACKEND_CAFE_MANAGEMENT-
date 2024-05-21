using DeerCoffeeShop.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Domain.Entities
{
    public class LateRecord : Entity, ISoftDelete
    {
        public required string EmployeeShiftID { get; set; }
        [ForeignKey("EmployeeShiftID")]
        public virtual required EmployeeShift EmployeeShift { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime? NgayXoa { get; set; }
        public string? NguoiXoaID { get; set; }
        [ForeignKey("NguoiXoaID")]
        public virtual Employee? NguoiXoa { get; set; }
        public bool IsDeleted { get; set; }
    }
}
