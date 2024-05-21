using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeerCoffeeShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiTaoID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhatID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShiftStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NguoiTaoID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhatID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    ManagerID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiXoaID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NguoiTaoID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhatID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhatCuoi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Employees_Employees_NguoiXoaID",
                        column: x => x.NguoiXoaID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Employees_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantChain",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RestaurantChainID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantChain_AdminID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RestaurantChainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantChainHQAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantChainType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantChainTotalBranches = table.Column<int>(type: "int", nullable: false),
                    RestaurantChainTotalEmployees = table.Column<int>(type: "int", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiXoaID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NguoiTaoID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhatID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhatCuoi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantChain", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RestaurantChain_Employees_NguoiXoaID",
                        column: x => x.NguoiXoaID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RestaurantChain_Employees_RestaurantChain_AdminID",
                        column: x => x.RestaurantChain_AdminID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantChainID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalEmployees = table.Column<int>(type: "int", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiXoaID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NguoiTaoID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhatID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhatCuoi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Restaurant_Employees_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurant_Employees_NguoiXoaID",
                        column: x => x.NguoiXoaID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Restaurant_RestaurantChain_RestaurantChainID",
                        column: x => x.RestaurantChainID,
                        principalTable: "RestaurantChain",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeShifts",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RestaurantID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShiftID = table.Column<int>(type: "int", nullable: false),
                    DateOfWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Actual_CheckIn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Actual_CheckOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalHours = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsOnTime = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiXoaID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NguoiTaoID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhatID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhatCuoi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeShifts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmployeeShifts_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_EmployeeShifts_Employees_NguoiXoaID",
                        column: x => x.NguoiXoaID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_EmployeeShifts_Restaurant_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeShifts_Shifts_ShiftID",
                        column: x => x.ShiftID,
                        principalTable: "Shifts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendences",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmplpoyeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeShiftID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiXoaID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiTaoID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhatID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhatCuoi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendences", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Attendences_EmployeeShifts_EmployeeShiftID",
                        column: x => x.EmployeeShiftID,
                        principalTable: "EmployeeShifts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendences_Employees_EmployeeShiftID",
                        column: x => x.EmployeeShiftID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attendences_Employees_NguoiXoaID",
                        column: x => x.NguoiXoaID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "LateRecords",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeShiftID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiXoaID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NguoiTaoID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiCapNhatID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhatCuoi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LateRecords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LateRecords_EmployeeShifts_EmployeeShiftID",
                        column: x => x.EmployeeShiftID,
                        principalTable: "EmployeeShifts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LateRecords_Employees_NguoiXoaID",
                        column: x => x.NguoiXoaID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendences_EmployeeShiftID",
                table: "Attendences",
                column: "EmployeeShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendences_NguoiXoaID",
                table: "Attendences",
                column: "NguoiXoaID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerID",
                table: "Employees",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NguoiXoaID",
                table: "Employees",
                column: "NguoiXoaID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleID",
                table: "Employees",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeShifts_EmployeeID",
                table: "EmployeeShifts",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeShifts_NguoiXoaID",
                table: "EmployeeShifts",
                column: "NguoiXoaID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeShifts_RestaurantID",
                table: "EmployeeShifts",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeShifts_ShiftID",
                table: "EmployeeShifts",
                column: "ShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_LateRecords_EmployeeShiftID",
                table: "LateRecords",
                column: "EmployeeShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_LateRecords_NguoiXoaID",
                table: "LateRecords",
                column: "NguoiXoaID");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_ManagerID",
                table: "Restaurant",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_NguoiXoaID",
                table: "Restaurant",
                column: "NguoiXoaID");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_RestaurantChainID",
                table: "Restaurant",
                column: "RestaurantChainID");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantChain_NguoiXoaID",
                table: "RestaurantChain",
                column: "NguoiXoaID");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantChain_RestaurantChain_AdminID",
                table: "RestaurantChain",
                column: "RestaurantChain_AdminID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendences");

            migrationBuilder.DropTable(
                name: "LateRecords");

            migrationBuilder.DropTable(
                name: "EmployeeShifts");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "RestaurantChain");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
