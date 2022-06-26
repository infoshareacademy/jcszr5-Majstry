using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarsztatAuthentication.Data.Migrations
{
    public partial class ChangePartsToPart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPart");

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PartId",
                table: "Orders",
                column: "PartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Parts_PartId",
                table: "Orders",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Parts_PartId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PartId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "Orders");

            migrationBuilder.CreateTable(
                name: "OrderPart",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    PartsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPart", x => new { x.OrdersId, x.PartsId });
                    table.ForeignKey(
                        name: "FK_OrderPart_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPart_Parts_PartsId",
                        column: x => x.PartsId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPart_PartsId",
                table: "OrderPart",
                column: "PartsId");
        }
    }
}
