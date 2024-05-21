using DeerCoffeeShop.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Domain.Entities
{
    public class Role : DefineTable
    {
        [Column("RoleName")]
        public override required string Name { get => base.Name; set => base.Name = value; }
    }
}
