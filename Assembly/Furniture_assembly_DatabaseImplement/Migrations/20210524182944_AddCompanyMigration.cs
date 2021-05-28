using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Furniture_assembly_DatabaseImplement.Migrations
{
    public partial class AddCompanyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreHouse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreHouseName = table.Column<string>(nullable: false),
                    ResponsiblePersonFCS = table.Column<string>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreHouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreHouseComponent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreHouseId = table.Column<int>(nullable: false),
                    ComponentId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreHouseComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreHouseComponent_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreHouseComponent_StoreHouse_StoreHouseId",
                        column: x => x.StoreHouseId,
                        principalTable: "StoreHouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreHouseComponent_ComponentId",
                table: "StoreHouseComponent",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreHouseComponent_StoreHouseId",
                table: "StoreHouseComponent",
                column: "StoreHouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreHouseComponent");

            migrationBuilder.DropTable(
                name: "StoreHouse");
        }
    }
}
