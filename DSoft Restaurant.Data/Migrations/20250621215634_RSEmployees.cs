using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSoft_Restaurant.Data.Migrations
{
    /// <inheritdoc />
    public partial class RSEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeCategory_TBEmployeeCategoryID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_TBEmployeeCategoryID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TBEmployeeCategoryID",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CategoryID",
                table: "Employees",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeCategory_CategoryID",
                table: "Employees",
                column: "CategoryID",
                principalTable: "EmployeeCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeCategory_CategoryID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CategoryID",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "TBEmployeeCategoryID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TBEmployeeCategoryID",
                table: "Employees",
                column: "TBEmployeeCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeCategory_TBEmployeeCategoryID",
                table: "Employees",
                column: "TBEmployeeCategoryID",
                principalTable: "EmployeeCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
