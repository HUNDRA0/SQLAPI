using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, 1, null, "Engineer" },
                    { 2, 2, null, "RnD" },
                    { 3, 2, null, "Doctor" },
                    { 4, 1, null, "Cleaner" }
                });

            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "EmployeeId", "PositionId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "EmployeePositionEmployeeId", "EmployeePositionPositionId", "FirstName", "LastName", "Salary", "Union" },
                values: new object[,]
                {
                    { 1, 1, null, null, "Mario", "Youssef", "30000", true },
                    { 2, 3, null, null, "Johnny", "Aho", "40000", true },
                    { 3, 4, null, null, "Jacob", "Ercan", "50000", true },
                    { 4, 4, null, null, "Robin", "Amoun", "50000", false }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "CompanyIdentityNumber", "CompanyName" },
                values: new object[,]
                {
                    { 1, 123456, "Tesla" },
                    { 2, 654321, "Apple" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "PositionName" },
                values: new object[,]
                {
                    { 1, "Doctor" },
                    { 2, "Engineer" },
                    { 3, "CEO" },
                    { 4, "RnD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
