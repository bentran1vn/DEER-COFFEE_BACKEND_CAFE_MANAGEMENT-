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
    internal class AttendenceConfiguration : IEntityTypeConfiguration<Attendence>
    {
        public void Configure(EntityTypeBuilder<Attendence> builder)
        {
            builder.HasOne(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.EmployeeShiftID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
