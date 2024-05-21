﻿// <auto-generated />
using System;
using DeerCoffeeShop.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeerCoffeeShop.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.Attendence", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeePictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeShiftID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmplpoyeeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgayCapNhatCuoi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayXoa")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiCapNhatID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTaoID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiXoaID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeShiftID");

                    b.HasIndex("NguoiXoaID");

                    b.ToTable("Attendences");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.Employee", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(7);

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(9);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(8);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(4);

                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnOrder(12);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ManagerID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(11);

                    b.Property<DateTime>("NgayCapNhatCuoi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayXoa")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiCapNhatID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTaoID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiXoaID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(5);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(10);

                    b.Property<int>("RoleID")
                        .HasColumnType("int")
                        .HasColumnOrder(6);

                    b.HasKey("ID");

                    b.HasIndex("ManagerID");

                    b.HasIndex("NguoiXoaID");

                    b.HasIndex("RoleID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = "1",
                            Address = "HCM",
                            DateJoined = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9536),
                            DateOfBirth = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9535),
                            Email = "Admin@gmail.com",
                            EmployeeID = 1,
                            FullName = "Admin",
                            IsActive = true,
                            IsDeleted = false,
                            NgayCapNhatCuoi = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9527),
                            NgayTao = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9539),
                            NguoiTaoID = "1",
                            Password = "123456",
                            PhoneNumber = "0123456789",
                            RoleID = 1
                        },
                        new
                        {
                            ID = "2",
                            Address = "HCM",
                            DateJoined = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9544),
                            DateOfBirth = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9543),
                            Email = "Manger@gmail.com",
                            EmployeeID = 2,
                            FullName = "Manger",
                            IsActive = true,
                            IsDeleted = false,
                            NgayCapNhatCuoi = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9542),
                            NgayTao = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9545),
                            NguoiTaoID = "1",
                            Password = "123456",
                            PhoneNumber = "0123456789",
                            RoleID = 2
                        },
                        new
                        {
                            ID = "3",
                            Address = "HCM",
                            DateJoined = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9548),
                            DateOfBirth = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9548),
                            Email = "Employee3@gmail.com",
                            EmployeeID = 3,
                            FullName = "Employee3",
                            IsActive = true,
                            IsDeleted = false,
                            NgayCapNhatCuoi = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9547),
                            NgayTao = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9549),
                            NguoiTaoID = "1",
                            Password = "123456",
                            PhoneNumber = "0123456789",
                            RoleID = 3
                        },
                        new
                        {
                            ID = "4",
                            Address = "HCM",
                            DateJoined = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9552),
                            DateOfBirth = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9552),
                            Email = "Employee4@gmail.com",
                            EmployeeID = 4,
                            FullName = "Employee4",
                            IsActive = true,
                            IsDeleted = false,
                            NgayCapNhatCuoi = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9551),
                            NgayTao = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9553),
                            NguoiTaoID = "1",
                            Password = "123456",
                            PhoneNumber = "0123456789",
                            RoleID = 3
                        },
                        new
                        {
                            ID = "5",
                            Address = "HCM",
                            DateJoined = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9556),
                            DateOfBirth = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9556),
                            Email = "Employee5@gmail.com",
                            EmployeeID = 5,
                            FullName = "Employee5",
                            IsActive = true,
                            IsDeleted = false,
                            NgayCapNhatCuoi = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9555),
                            NgayTao = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9557),
                            NguoiTaoID = "1",
                            Password = "123456",
                            PhoneNumber = "0123456789",
                            RoleID = 3
                        });
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.EmployeeShift", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Actual_CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Actual_CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfWork")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnTime")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgayCapNhatCuoi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayXoa")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiCapNhatID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTaoID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiXoaID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ShiftID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TotalHours")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("NguoiXoaID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("ShiftID");

                    b.ToTable("EmployeeShifts");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.LateRecord", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeShiftID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgayCapNhatCuoi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayXoa")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiCapNhatID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTaoID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiXoaID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeShiftID");

                    b.HasIndex("NguoiXoaID");

                    b.ToTable("LateRecords");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.Restaurant", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ManagerID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayCapNhatCuoi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayXoa")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiCapNhatID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTaoID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiXoaID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RestaurantAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantChainID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("RestaurantID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalEmployees")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ManagerID");

                    b.HasIndex("NguoiXoaID");

                    b.HasIndex("RestaurantChainID");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.RestaurantChain", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgayCapNhatCuoi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayXoa")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiCapNhatID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTaoID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiXoaID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RestaurantChainHQAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantChainID")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantChainName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantChainTotalBranches")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantChainTotalEmployees")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantChainType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantChain_AdminID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("NguoiXoaID");

                    b.HasIndex("RestaurantChain_AdminID");

                    b.ToTable("RestaurantChain");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RoleName");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiCapNhatID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTaoID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Admin",
                            NgayTao = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9330),
                            NguoiTaoID = "1"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Manger",
                            NgayTao = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9350),
                            NguoiTaoID = "1"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Employee",
                            NgayTao = new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9351),
                            NguoiTaoID = "1"
                        });
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.Shift", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ShiftName");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiCapNhatID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTaoID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShiftDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ShiftEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShiftStart")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.Attendence", b =>
                {
                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeShiftID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeerCoffeeShop.Domain.Entities.EmployeeShift", "EmployeeShift")
                        .WithMany()
                        .HasForeignKey("EmployeeShiftID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "NguoiXoa")
                        .WithMany()
                        .HasForeignKey("NguoiXoaID");

                    b.Navigation("Employee");

                    b.Navigation("EmployeeShift");

                    b.Navigation("NguoiXoa");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.Employee", b =>
                {
                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID");

                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "NguoiXoa")
                        .WithMany()
                        .HasForeignKey("NguoiXoaID");

                    b.HasOne("DeerCoffeeShop.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");

                    b.Navigation("NguoiXoa");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.EmployeeShift", b =>
                {
                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "NguoiXoa")
                        .WithMany()
                        .HasForeignKey("NguoiXoaID");

                    b.HasOne("DeerCoffeeShop.Domain.Entities.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeerCoffeeShop.Domain.Entities.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("NguoiXoa");

                    b.Navigation("Restaurant");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.LateRecord", b =>
                {
                    b.HasOne("DeerCoffeeShop.Domain.Entities.EmployeeShift", "EmployeeShift")
                        .WithMany()
                        .HasForeignKey("EmployeeShiftID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "NguoiXoa")
                        .WithMany()
                        .HasForeignKey("NguoiXoaID");

                    b.Navigation("EmployeeShift");

                    b.Navigation("NguoiXoa");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.Restaurant", b =>
                {
                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "NguoiXoa")
                        .WithMany()
                        .HasForeignKey("NguoiXoaID");

                    b.HasOne("DeerCoffeeShop.Domain.Entities.RestaurantChain", "RestaurantChain")
                        .WithMany()
                        .HasForeignKey("RestaurantChainID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Manager");

                    b.Navigation("NguoiXoa");

                    b.Navigation("RestaurantChain");
                });

            modelBuilder.Entity("DeerCoffeeShop.Domain.Entities.RestaurantChain", b =>
                {
                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "NguoiXoa")
                        .WithMany()
                        .HasForeignKey("NguoiXoaID");

                    b.HasOne("DeerCoffeeShop.Domain.Entities.Employee", "RestaurantChain_Admin")
                        .WithMany()
                        .HasForeignKey("RestaurantChain_AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiXoa");

                    b.Navigation("RestaurantChain_Admin");
                });
#pragma warning restore 612, 618
        }
    }
}
