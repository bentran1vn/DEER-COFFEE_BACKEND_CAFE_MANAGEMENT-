using DeerCoffeeShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeerCoffeeShop.Domain.Entities
{
    public class Role : DefineTable
    {
        [Column("RoleName")]
        public override required string Name { get => base.Name; set => base.Name = value; }
    }
}
