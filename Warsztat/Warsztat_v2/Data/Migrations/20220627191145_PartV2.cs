using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarsztatAuthentication.Data.Migrations
{
    public partial class PartV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_PartId",
                table: "Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PartId",
                table: "Orders",
                column: "PartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_PartId",
                table: "Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PartId",
                table: "Orders",
                column: "PartId",
                unique: true);
        }
    }
}
