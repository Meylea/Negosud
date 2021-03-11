using Microsoft.EntityFrameworkCore.Migrations;

namespace Negosud_MVC.Migrations
{
    public partial class FixImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgURL",
                table: "Items",
                newName: "ImgUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgUrl",
                table: "Items",
                newName: "ImgURL");
        }
    }
}
