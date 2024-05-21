using DeerCoffeeShop.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Domain.Entities
{
    public class Employee : Entity, ISoftDelete
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 2)]
        public required int EmployeeID { get; set; }
        [Column(Order = 3)]
        public required string FullName { get; set; }
        [EmailAddress]
        [Column(Order = 4)]
        public required string Email { get; set; }
        [Column(Order = 5)]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [Phone]
        [Column(Order = 10)]
        public required string PhoneNumber { get; set; }
        [DataType(DataType.MultilineText)]
        [Column(Order = 7)]
        public required string Address { get; set; }
        [DataType(DataType.Date)]
        [Column(Order = 8)]
        public required DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        [Column(Order = 9)]
        public required DateTime DateJoined { get; set; }
        [Column(Order = 6)]
        public required int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public virtual Role? Role { get; set; }
        [Column(Order = 11)]
        public string? ManagerID { get; set; }
        [ForeignKey("ManagerID")]
        public virtual Employee? Manager { get; set; }
        [Column(Order = 12)]
        public required bool IsActive { get; set; }
        public string? NguoiXoaID { get; set; }
        [ForeignKey("NguoiXoaID")]
        public virtual Employee? NguoiXoa { get; set; }
        [DataType(DataType.Date)]
        public DateTime? NgayXoa { get; set; }
        public bool IsDeleted { get; set; }
    }
}
