using DeerCoffeeShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeerCoffeeShop.Domain.Entities
{
    public class Shift : DefineTable
    {
        [Column("ShiftName")]
        public override required string Name { get => base.Name; set => base.Name = value; }
        [DataType(DataType.Time)]
        public required DateTime ShiftStart { get; set; }
        [DataType(DataType.Time)]
        public required DateTime ShiftEnd { get; set; }
        public required string ShiftDescription { get; set; }
        public required bool IsActive { get; set; }
    }
}