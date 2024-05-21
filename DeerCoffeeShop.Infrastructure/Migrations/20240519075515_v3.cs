using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeerCoffeeShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "ManagerID",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Employees",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit")
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 2)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 7);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "ManagerID",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Employees",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 2)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "1",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3805), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3797), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "2",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3812), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3812), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3810), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "3",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "4",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3822), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3822), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3820), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "5",
                columns: new[] { "DateJoined", "DateOfBirth", "NgayCapNhatCuoi", "NgayTao" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3827), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3826), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3825), new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2024, 5, 19, 14, 48, 37, 152, DateTimeKind.Local).AddTicks(3630));
        }
    }
}
