using Microsoft.EntityFrameworkCore.Migrations;

namespace Negosud_MVC.Migrations
{
    public partial class CommandIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientCommandLines_ClientCommands_ClientCommandId",
                table: "ClientCommandLines");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierCommandLines_SupplierCommands_SupplierCommandId",
                table: "SupplierCommandLines");

            migrationBuilder.DropColumn(
                name: "CommandId",
                table: "SupplierCommandLines");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierCommandId",
                table: "SupplierCommandLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientCommandId",
                table: "ClientCommandLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCommandLines_ClientCommands_ClientCommandId",
                table: "ClientCommandLines",
                column: "ClientCommandId",
                principalTable: "ClientCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierCommandLines_SupplierCommands_SupplierCommandId",
                table: "SupplierCommandLines",
                column: "SupplierCommandId",
                principalTable: "SupplierCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientCommandLines_ClientCommands_ClientCommandId",
                table: "ClientCommandLines");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierCommandLines_SupplierCommands_SupplierCommandId",
                table: "SupplierCommandLines");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierCommandId",
                table: "SupplierCommandLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CommandId",
                table: "SupplierCommandLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ClientCommandId",
                table: "ClientCommandLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCommandLines_ClientCommands_ClientCommandId",
                table: "ClientCommandLines",
                column: "ClientCommandId",
                principalTable: "ClientCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierCommandLines_SupplierCommands_SupplierCommandId",
                table: "SupplierCommandLines",
                column: "SupplierCommandId",
                principalTable: "SupplierCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
