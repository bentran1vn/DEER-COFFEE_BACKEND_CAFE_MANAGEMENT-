using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeerCoffeeShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRequireBaseEnity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "RestaurantChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "LateRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "EmployeeShifts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "Attendences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "2",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "3",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "4",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "5",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2024, 5, 31, 21, 4, 11, 310, DateTimeKind.Local).AddTicks(7560));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "RestaurantChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "LateRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "EmployeeShifts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NguoiTaoID",
                table: "Attendences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4363), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4362), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4359), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "2",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4397), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4397), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4396), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "3",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4402), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4402), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4401), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "4",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4407), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4406), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4405), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "5",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4411), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4410), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4409), new DateTime(2024, 5, 21, 16, 20, 38, 777, DateTimeKind.Local).AddTicks(4412) });

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
    }
}
