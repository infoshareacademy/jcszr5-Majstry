using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarsztatAuthentication.Data.Migrations
{
    public partial class PartOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartId1",
                table: "Orders",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Parts_PartId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PartId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartId1",
                table: "Orders");
        }
    }
}
