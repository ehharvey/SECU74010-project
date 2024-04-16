using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreWebApp.Migrations
{
    /// <inheritdoc />
    public partial class purchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_ZipCodes_ZipCode",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Purchase_PurchaseId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Address_AddressId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseToProductJunction_Purchase_PurchaseId",
                table: "PurchaseToProductJunction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Purchase",
                newName: "Purchases");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_AddressId",
                table: "Purchases",
                newName: "IX_Purchases_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_ZipCode",
                table: "Addresses",
                newName: "IX_Addresses_ZipCode");

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Purchases",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_ZipCodes_ZipCode",
                table: "Addresses",
                column: "ZipCode",
                principalTable: "ZipCodes",
                principalColumn: "ZipCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Purchases_PurchaseId",
                table: "Products",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Addresses_AddressId",
                table: "Purchases",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseToProductJunction_Purchases_PurchaseId",
                table: "PurchaseToProductJunction",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_ZipCodes_ZipCode",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Purchases_PurchaseId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Addresses_AddressId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseToProductJunction_Purchases_PurchaseId",
                table: "PurchaseToProductJunction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Purchases");

            migrationBuilder.RenameTable(
                name: "Purchases",
                newName: "Purchase");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_AddressId",
                table: "Purchase",
                newName: "IX_Purchase_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_ZipCode",
                table: "Address",
                newName: "IX_Address_ZipCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_ZipCodes_ZipCode",
                table: "Address",
                column: "ZipCode",
                principalTable: "ZipCodes",
                principalColumn: "ZipCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Purchase_PurchaseId",
                table: "Products",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Address_AddressId",
                table: "Purchase",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseToProductJunction_Purchase_PurchaseId",
                table: "PurchaseToProductJunction",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
