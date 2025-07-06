using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSoft_Restaurant.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewRSH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_GroupExpenses_TBGroupExpensesID",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemDeliveryPrices_GroupExpenses_TBGroupExpensesID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropIndex(
                name: "IX_ItemDeliveryPrices_TBGroupExpensesID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_TBGroupExpensesID",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "TBGroupExpensesID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropColumn(
                name: "TBGroupExpensesID",
                table: "Expenses");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_GroupID",
                table: "Expenses",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_GroupExpenses_GroupID",
                table: "Expenses",
                column: "GroupID",
                principalTable: "GroupExpenses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_GroupExpenses_GroupID",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_GroupID",
                table: "Expenses");

            migrationBuilder.AddColumn<int>(
                name: "TBGroupExpensesID",
                table: "ItemDeliveryPrices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TBGroupExpensesID",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemDeliveryPrices_TBGroupExpensesID",
                table: "ItemDeliveryPrices",
                column: "TBGroupExpensesID");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_TBGroupExpensesID",
                table: "Expenses",
                column: "TBGroupExpensesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_GroupExpenses_TBGroupExpensesID",
                table: "Expenses",
                column: "TBGroupExpensesID",
                principalTable: "GroupExpenses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDeliveryPrices_GroupExpenses_TBGroupExpensesID",
                table: "ItemDeliveryPrices",
                column: "TBGroupExpensesID",
                principalTable: "GroupExpenses",
                principalColumn: "ID");
        }
    }
}
