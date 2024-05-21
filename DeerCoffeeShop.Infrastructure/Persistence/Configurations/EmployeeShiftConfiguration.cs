using DeerCoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Infrastructure.Persistence.Configurations
{
    internal class EmployeeShiftConfiguration : IEntityTypeConfiguration<EmployeeShift>
    {
        public void Configure(EntityTypeBuilder<EmployeeShift> builder)
        {
            builder.HasOne(es => es.Employee)
                .WithMany()
                .HasForeignKey(es => es.EmployeeID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
