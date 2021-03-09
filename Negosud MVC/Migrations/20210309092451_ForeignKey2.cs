using Microsoft.EntityFrameworkCore.Migrations;

namespace Negosud_MVC.Migrations
{
    public partial class ForeignKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientCommandLines_Items_ItemID",
                table: "ClientCommandLines");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "ClientCommandLines",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCommandLines_ItemID",
                table: "ClientCommandLines",
                newName: "IX_ClientCommandLines_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCommandLines_Items_ItemId",
                table: "ClientCommandLines",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientCommandLines_Items_ItemId",
                table: "ClientCommandLines");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ClientCommandLines",
                newName: "ItemID");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCommandLines_ItemId",
                table: "ClientCommandLines",
                newName: "IX_ClientCommandLines_ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCommandLines_Items_ItemID",
                table: "ClientCommandLines",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
