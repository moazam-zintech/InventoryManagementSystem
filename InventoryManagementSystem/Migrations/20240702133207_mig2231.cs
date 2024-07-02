using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class mig2231 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdcutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DemandDate = table.Column<DateOnly>(type: "date", nullable: false),
                    RecievedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Stock = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventories_Prodcuts_ProdcutId",
                        column: x => x.ProdcutId,
                        principalTable: "Prodcuts",
                        principalColumn: "ProdcutId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_inventories_ProdcutId",
                table: "inventories",
                column: "ProdcutId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventories");
        }
    }
}
