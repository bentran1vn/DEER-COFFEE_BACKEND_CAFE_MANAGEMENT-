using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeerCoffeeShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "EmployeeShifts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeNote",
                table: "EmployeeShifts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsEmpty",
                table: "EmployeeShifts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "EmployeeShifts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "EmployeeShifts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4363), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4362), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4359), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4364), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "2",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4397), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4397), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4396), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4398), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "3",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4402), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4402), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4401), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4403), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "4",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4407), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4406), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4405), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4407), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "5",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4411), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4410), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4409), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4412), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4153));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeNote",
                table: "EmployeeShifts");

            migrationBuilder.DropColumn(
                name: "IsEmpty",
                table: "EmployeeShifts");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "EmployeeShifts");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "EmployeeShifts");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "EmployeeShifts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9535), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9527), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "2",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9544), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9543), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9542), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "3",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9548), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9548), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9547), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "4",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9552), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9552), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9551), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "5",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9555), new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2024, 5, 19, 14, 55, 15, 611, DateTimeKind.Local).AddTicks(9351));
        }
    }
}
