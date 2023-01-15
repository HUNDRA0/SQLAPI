using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class Sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeePositions_EmployeePositionEmployeeId_EmployeePositionPositionId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeePositionEmployeeId_EmployeePositionPositionId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeePositionEmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeePositionPositionId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "EmployeeEmployeePosition",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    EmployeePositionsEmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeePositionsPositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEmployeePosition", x => new { x.EmployeesId, x.EmployeePositionsEmployeeId, x.EmployeePositionsPositionId });
                    table.ForeignKey(
                        name: "FK_EmployeeEmployeePosition_EmployeePositions_EmployeePositionsEmployeeId_EmployeePositionsPositionId",
                        columns: x => new { x.EmployeePositionsEmployeeId, x.EmployeePositionsPositionId },
                        principalTable: "EmployeePositions",
                        principalColumns: new[] { "EmployeeId", "PositionId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeEmployeePosition_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEmployeePosition_EmployeePositionsEmployeeId_EmployeePositionsPositionId",
                table: "EmployeeEmployeePosition",
                columns: new[] { "EmployeePositionsEmployeeId", "EmployeePositionsPositionId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeEmployeePosition");

            migrationBuilder.AddColumn<int>(
                name: "EmployeePositionEmployeeId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeePositionPositionId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeePositionEmployeeId_EmployeePositionPositionId",
                table: "Employees",
                columns: new[] { "EmployeePositionEmployeeId", "EmployeePositionPositionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeePositions_EmployeePositionEmployeeId_EmployeePositionPositionId",
                table: "Employees",
                columns: new[] { "EmployeePositionEmployeeId", "EmployeePositionPositionId" },
                principalTable: "EmployeePositions",
                principalColumns: new[] { "EmployeeId", "PositionId" });
        }
    }
}
