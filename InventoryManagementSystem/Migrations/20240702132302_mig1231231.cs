using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class mig1231231 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_Prodcuts_ProdcutId",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_orders_ProdcutId",
                table: "Orders",
                newName: "IX_Orders_ProdcutId");

            migrationBuilder.AddColumn<Guid>(
                name: "ordersOrderID",
                table: "customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_customers_ordersOrderID",
                table: "customers",
                column: "ordersOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_Orders_ordersOrderID",
                table: "customers",
                column: "ordersOrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Prodcuts_ProdcutId",
                table: "Orders",
                column: "ProdcutId",
                principalTable: "Prodcuts",
                principalColumn: "ProdcutId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_Orders_ordersOrderID",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Prodcuts_ProdcutId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_customers_ordersOrderID",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "ordersOrderID",
                table: "customers");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ProdcutId",
                table: "orders",
                newName: "IX_orders_ProdcutId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Prodcuts_ProdcutId",
                table: "orders",
                column: "ProdcutId",
                principalTable: "Prodcuts",
                principalColumn: "ProdcutId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
