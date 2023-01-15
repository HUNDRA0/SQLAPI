using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Departments_DepartmentId",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "DepartmentOrganization");

            migrationBuilder.DropTable(
                name: "EmployeeEmployeePosition");

            migrationBuilder.DropTable(
                name: "EmployeePositionPosition");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Departments",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_DepartmentId",
                table: "Departments",
                newName: "IX_Departments_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Organizations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_DepartmentId",
                table: "Organizations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositions_PositionId",
                table: "EmployeePositions",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_Employees_EmployeeId",
                table: "EmployeePositions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_Positions_PositionId",
                table: "EmployeePositions",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Departments_DepartmentId",
                table: "Organizations",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_Employees_EmployeeId",
                table: "EmployeePositions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_Positions_PositionId",
                table: "EmployeePositions");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Departments_DepartmentId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_DepartmentId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePositions_PositionId",
                table: "EmployeePositions");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Organizations");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Departments",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                newName: "IX_Departments_DepartmentId");

            migrationBuilder.CreateTable(
                name: "DepartmentOrganization",
                columns: table => new
                {
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    OrganizationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentOrganization", x => new { x.DepartmentsId, x.OrganizationsId });
                    table.ForeignKey(
                        name: "FK_DepartmentOrganization_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentOrganization_Organizations_OrganizationsId",
                        column: x => x.OrganizationsId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "EmployeePositionPosition",
                columns: table => new
                {
                    PositionsId = table.Column<int>(type: "int", nullable: false),
                    EmployeePositionsEmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeePositionsPositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositionPosition", x => new { x.PositionsId, x.EmployeePositionsEmployeeId, x.EmployeePositionsPositionId });
                    table.ForeignKey(
                        name: "FK_EmployeePositionPosition_EmployeePositions_EmployeePositionsEmployeeId_EmployeePositionsPositionId",
                        columns: x => new { x.EmployeePositionsEmployeeId, x.EmployeePositionsPositionId },
                        principalTable: "EmployeePositions",
                        principalColumns: new[] { "EmployeeId", "PositionId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePositionPosition_Positions_PositionsId",
                        column: x => x.PositionsId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentOrganization_OrganizationsId",
                table: "DepartmentOrganization",
                column: "OrganizationsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEmployeePosition_EmployeePositionsEmployeeId_EmployeePositionsPositionId",
                table: "EmployeeEmployeePosition",
                columns: new[] { "EmployeePositionsEmployeeId", "EmployeePositionsPositionId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositionPosition_EmployeePositionsEmployeeId_EmployeePositionsPositionId",
                table: "EmployeePositionPosition",
                columns: new[] { "EmployeePositionsEmployeeId", "EmployeePositionsPositionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Departments_DepartmentId",
                table: "Departments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
