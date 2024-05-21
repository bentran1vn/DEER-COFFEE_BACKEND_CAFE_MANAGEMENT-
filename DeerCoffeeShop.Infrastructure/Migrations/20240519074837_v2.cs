using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeerCoffeeShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "RoleName", "NgayCapNhat", "NgayTao", "NguoiCapNhatID", "NguoiTaoID" },
                values: new object[,]
                {
                    { 1, "Admin", null, new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3613), null, "1" },
                    { 2, "Manger", null, new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3628), null, "1" },
                    { 3, "Employee", null, new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3630), null, "1" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Address", "DateJoined", "DateOfBirth", "Email", "EmployeeID", "FullName", "IsActive", "IsDeleted", "ManagerID", "NgayCapNhatCuoi", "NgayTao", "NgayXoa", "NguoiCapNhatID", "NguoiTaoID", "NguoiXoaID", "Password", "PhoneNumber", "RoleID" },
                values: new object[,]
                {
                    { "1", "HCM", new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3805), "Admin@gmail.com", 1, "Admin", true, false, null, new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3797), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3807), null, null, "1", null, "123456", "0123456789", 1 },
                    { "2", "HCM", new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3812), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3812), "Manger@gmail.com", 2, "Manger", true, false, null, new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3810), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3813), null, null, "1", null, "123456", "0123456789", 2 },
                    { "3", "HCM", new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3817), "Employee3@gmail.com", 3, "Employee3", true, false, null, new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3819), null, null, "1", null, "123456", "0123456789", 3 },
                    { "4", "HCM", new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3822), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3822), "Employee4@gmail.com", 4, "Employee4", true, false, null, new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3820), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3823), null, null, "1", null, "123456", "0123456789", 3 },
                    { "5", "HCM", new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3827), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3826), "Employee5@gmail.com", 5, "Employee5", true, false, null, new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3825), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3828), null, null, "1", null, "123456", "0123456789", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
