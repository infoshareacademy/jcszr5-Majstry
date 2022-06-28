using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarsztatAuthentication.Data.Migrations
{
    public partial class OrderProperitiesChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarModel",
                table: "Orders",
                newName: "Model_Name");

            migrationBuilder.RenameColumn(
                name: "CarMake",
                table: "Orders",
                newName: "MakeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model_Name",
                table: "Orders",
                newName: "CarModel");

            migrationBuilder.RenameColumn(
                name: "MakeName",
                table: "Orders",
                newName: "CarMake");
        }
    }
}
