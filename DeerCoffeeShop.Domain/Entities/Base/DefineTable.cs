using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Domain.Entities.Base
{
    public abstract class DefineTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("Name")]
        public virtual required string Name { get; set; }

        public required string NguoiTaoID { get; set; }
        public required DateTime NgayTao { get; set; }

        public string? NguoiCapNhatID { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}
