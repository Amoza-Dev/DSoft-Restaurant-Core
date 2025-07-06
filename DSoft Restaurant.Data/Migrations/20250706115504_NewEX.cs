using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSoft_Restaurant.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewEX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TBGroupExpensesID",
                table: "ItemDeliveryPrices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemDeliveryPrices_TBGroupExpensesID",
                table: "ItemDeliveryPrices",
                column: "TBGroupExpensesID");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDeliveryPrices_GroupExpenses_TBGroupExpensesID",
                table: "ItemDeliveryPrices",
                column: "TBGroupExpensesID",
                principalTable: "GroupExpenses",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemDeliveryPrices_GroupExpenses_TBGroupExpensesID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropIndex(
                name: "IX_ItemDeliveryPrices_TBGroupExpensesID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropColumn(
                name: "TBGroupExpensesID",
                table: "ItemDeliveryPrices");
        }
    }
}
