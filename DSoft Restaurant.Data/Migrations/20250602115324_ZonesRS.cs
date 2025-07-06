using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSoft_Restaurant.Data.Migrations
{
    /// <inheritdoc />
    public partial class ZonesRS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Zones_TBZonesID",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_TBZonesID",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "TBZonesID",
                table: "Tables");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_ZoneID",
                table: "Tables",
                column: "ZoneID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Zones_ZoneID",
                table: "Tables",
                column: "ZoneID",
                principalTable: "Zones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Zones_ZoneID",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_ZoneID",
                table: "Tables");

            migrationBuilder.AddColumn<int>(
                name: "TBZonesID",
                table: "Tables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tables_TBZonesID",
                table: "Tables",
                column: "TBZonesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Zones_TBZonesID",
                table: "Tables",
                column: "TBZonesID",
                principalTable: "Zones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
