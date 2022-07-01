using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarsztatAuthentication.Data.Migrations
{
    public partial class PropertyOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Parts_PartId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PartId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PartId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartId1",
                table: "Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PartId",
                table: "Orders",
                column: "PartId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_PartId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "PartId1",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PartId",
                table: "Orders",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PartId1",
                table: "Orders",
                column: "PartId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Parts_PartId1",
                table: "Orders",
                column: "PartId1",
                principalTable: "Parts",
                principalColumn: "Id");
        }
    }
}
