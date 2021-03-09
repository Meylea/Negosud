using Microsoft.EntityFrameworkCore.Migrations;

namespace Negosud_MVC.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientCommandLines_Items_ItemId",
                table: "ClientCommandLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientCommands_Clients_ClientId",
                table: "ClientCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Producers_ProducerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Suppliers_SupplierId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Types_TypeId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierCommandLines_Items_ItemId",
                table: "SupplierCommandLines");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ClientCommandLines",
                newName: "ItemID");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCommandLines_ItemId",
                table: "ClientCommandLines",
                newName: "IX_ClientCommandLines_ItemID");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "SupplierCommandLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommandId",
                table: "SupplierCommandLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProducerId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientCommands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemID",
                table: "ClientCommandLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCommandLines_Items_ItemID",
                table: "ClientCommandLines",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCommands_Clients_ClientId",
                table: "ClientCommands",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Producers_ProducerId",
                table: "Items",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Suppliers_SupplierId",
                table: "Items",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Types_TypeId",
                table: "Items",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierCommandLines_Items_ItemId",
                table: "SupplierCommandLines",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientCommandLines_Items_ItemID",
                table: "ClientCommandLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientCommands_Clients_ClientId",
                table: "ClientCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Producers_ProducerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Suppliers_SupplierId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Types_TypeId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierCommandLines_Items_ItemId",
                table: "SupplierCommandLines");

            migrationBuilder.DropColumn(
                name: "CommandId",
                table: "SupplierCommandLines");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "ClientCommandLines",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientCommandLines_ItemID",
                table: "ClientCommandLines",
                newName: "IX_ClientCommandLines_ItemId");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "SupplierCommandLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProducerId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientCommands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "ClientCommandLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCommandLines_Items_ItemId",
                table: "ClientCommandLines",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientCommands_Clients_ClientId",
                table: "ClientCommands",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Producers_ProducerId",
                table: "Items",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Suppliers_SupplierId",
                table: "Items",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Types_TypeId",
                table: "Items",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierCommandLines_Items_ItemId",
                table: "SupplierCommandLines",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
