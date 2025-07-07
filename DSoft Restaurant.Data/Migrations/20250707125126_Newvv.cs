using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSoft_Restaurant.Data.Migrations
{
    /// <inheritdoc />
    public partial class Newvv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "Boxs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Boxs");
        }
    }
}
