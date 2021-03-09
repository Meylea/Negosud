using Microsoft.EntityFrameworkCore.Migrations;

namespace Negosud_MVC.Migrations
{
    public partial class Vin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgURL",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgURL",
                table: "Items");
        }
    }
}
