using DeerCoffeeShop.Domain.Common.Interfaces;
using DeerCoffeeShop.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace DeerCoffeeShop.Infrastructure.Persistence.Configurations
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IUnitOfWork
    {

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RestaurantChain> Restaurants { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<EmployeeShift> EmployeeShifts { get; set; }
        public virtual DbSet<Attendence> Attendences { get; set; }
        public virtual DbSet<LateRecord> LateRecords { get; set; }
        public virtual DbSet<RestaurantChain> RestaurantChains { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RestaurantConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeShiftConfiguration());
            modelBuilder.ApplyConfiguration(new AttendenceConfiguration());
            ConfigureModel(modelBuilder);

        }
        private static void ConfigureModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 1,
                    Name = "Admin",
                    NguoiTaoID = "1",
                    NgayTao = DateTime.Now,
                },
                new Role
                {
                    ID = 2,
                    Name = "Manger",
                    NguoiTaoID = "1",
                    NgayTao = DateTime.Now,
                },
                new Role
                {
                    ID = 3,
                    Name = "Employee",
                    NguoiTaoID = "1",
                    NgayTao = DateTime.Now,
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    ID = "1",
                    EmployeeID = 1,
                    FullName = "Admin",
                    Email = "Admin@gmail.com",
                    Password = "123456",
                    PhoneNumber = "0123456789",
                    Address = "HCM",
                    DateOfBirth = DateTime.Now,
                    DateJoined = DateTime.Now,
                    RoleID = 1,
                    IsActive = true,
                    NguoiTaoID = "1",
                    NgayTao = DateTime.Now,
                },
                new Employee
                {
                    ID = "2",
                    EmployeeID = 2,
                    FullName = "Manger",
                    Email = "Manger@gmail.com",
                    Password = "123456",
                    PhoneNumber = "0123456789",
                    Address = "HCM",
                    DateOfBirth = DateTime.Now,
                    DateJoined = DateTime.Now,
                    RoleID = 2,
                    IsActive = true,
                    NguoiTaoID = "1",
                    NgayTao = DateTime.Now,
                },
                new Employee
                {
                    ID = "3",
                    EmployeeID = 3,
                    FullName = "Employee3",
                    Email = "Employee3@gmail.com",
                    Password = "123456",
                    PhoneNumber = "0123456789",
                    Address = "HCM",
                    DateOfBirth = DateTime.Now,
                    DateJoined = DateTime.Now,
                    RoleID = 3,
                    IsActive = true,
                    NguoiTaoID = "1",
                    NgayTao = DateTime.Now,
                },
                 new Employee
                 {
                     ID = "4",
                     EmployeeID = 4,
                     FullName = "Employee4",
                     Email = "Employee4@gmail.com",
                     Password = "123456",
                     PhoneNumber = "0123456789",
                     Address = "HCM",
                     DateOfBirth = DateTime.Now,
                     DateJoined = DateTime.Now,
                     RoleID = 3,
                     IsActive = true,
                     NguoiTaoID = "1",
                     NgayTao = DateTime.Now,
                 },
                  new Employee
                  {
                      ID = "5",
                      EmployeeID = 5,
                      FullName = "Employee5",
                      Email = "Employee5@gmail.com",
                      Password = "123456",
                      PhoneNumber = "0123456789",
                      Address = "HCM",
                      DateOfBirth = DateTime.Now,
                      DateJoined = DateTime.Now,
                      RoleID = 3,
                      IsActive = true,
                      NguoiTaoID = "1",
                      NgayTao = DateTime.Now,
                  });
        }
    }
}


