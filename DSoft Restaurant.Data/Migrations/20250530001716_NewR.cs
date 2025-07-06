using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSoft_Restaurant.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemDeliveryPrices_DeliveryCompany_DeliverCompanyID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemDeliveryPrices_Items_TBItemsID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Categoroy_tBCategoryID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_tBCategoryID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_ItemDeliveryPrices_DeliverCompanyID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropIndex(
                name: "IX_ItemDeliveryPrices_TBItemsID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropColumn(
                name: "tBCategoryID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DeliverCompanyID",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropColumn(
                name: "TBItemsID",
                table: "ItemDeliveryPrices");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDeliveryPrices_DeliveryCompanyId",
                table: "ItemDeliveryPrices",
                column: "DeliveryCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDeliveryPrices_ItemId",
                table: "ItemDeliveryPrices",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDeliveryPrices_DeliveryCompany_DeliveryCompanyId",
                table: "ItemDeliveryPrices",
                column: "DeliveryCompanyId",
                principalTable: "DeliveryCompany",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDeliveryPrices_Items_ItemId",
                table: "ItemDeliveryPrices",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Categoroy_CategoryId",
                table: "Items",
                column: "CategoryId",
                principalTable: "Categoroy",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemDeliveryPrices_DeliveryCompany_DeliveryCompanyId",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemDeliveryPrices_Items_ItemId",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Categoroy_CategoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CategoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_ItemDeliveryPrices_DeliveryCompanyId",
                table: "ItemDeliveryPrices");

            migrationBuilder.DropIndex(
                name: "IX_ItemDeliveryPrices_ItemId",
                table: "ItemDeliveryPrices");

            migrationBuilder.AddColumn<int>(
                name: "tBCategoryID",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeliverCompanyID",
                table: "ItemDeliveryPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TBItemsID",
                table: "ItemDeliveryPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_tBCategoryID",
                table: "Items",
                column: "tBCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDeliveryPrices_DeliverCompanyID",
                table: "ItemDeliveryPrices",
                column: "DeliverCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDeliveryPrices_TBItemsID",
                table: "ItemDeliveryPrices",
                column: "TBItemsID");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDeliveryPrices_DeliveryCompany_DeliverCompanyID",
                table: "ItemDeliveryPrices",
                column: "DeliverCompanyID",
                principalTable: "DeliveryCompany",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDeliveryPrices_Items_TBItemsID",
                table: "ItemDeliveryPrices",
                column: "TBItemsID",
                principalTable: "Items",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Categoroy_tBCategoryID",
                table: "Items",
                column: "tBCategoryID",
                principalTable: "Categoroy",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
