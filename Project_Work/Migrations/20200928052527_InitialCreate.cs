using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Work.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "ContactualStaffs",
                columns: table => new
                {
                    ContactualStaffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactualStaffName = table.Column<string>(maxLength: 40, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    WeeklySalary = table.Column<decimal>(type: "money", nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactualStaffs", x => x.ContactualStaffId);
                    table.ForeignKey(
                        name: "FK_ContactualStaffs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermanentStaffs",
                columns: table => new
                {
                    PermanentStaffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PermanentStaffName = table.Column<string>(maxLength: 40, nullable: false),
                    JoinDate = table.Column<DateTime>(type: "date", nullable: false),
                    MonthlySalary = table.Column<decimal>(type: "money", nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermanentStaffs", x => x.PermanentStaffId);
                    table.ForeignKey(
                        name: "FK_PermanentStaffs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactualStaffs_DepartmentId",
                table: "ContactualStaffs",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PermanentStaffs_DepartmentId",
                table: "PermanentStaffs",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactualStaffs");

            migrationBuilder.DropTable(
                name: "PermanentStaffs");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
