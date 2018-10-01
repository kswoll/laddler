using Microsoft.EntityFrameworkCore.Migrations;

namespace Laddler.Api.Migrations
{
    public partial class FleshOutMoreTables4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_DbDimensionGroup_DimensionGroupId",
                table: "Dimensions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbDimensionGroup",
                table: "DbDimensionGroup");

            migrationBuilder.RenameTable(
                name: "DbDimensionGroup",
                newName: "DimensionGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DimensionGroups",
                table: "DimensionGroups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dimensions_DimensionGroups_DimensionGroupId",
                table: "Dimensions",
                column: "DimensionGroupId",
                principalTable: "DimensionGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_DimensionGroups_DimensionGroupId",
                table: "Dimensions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DimensionGroups",
                table: "DimensionGroups");

            migrationBuilder.RenameTable(
                name: "DimensionGroups",
                newName: "DbDimensionGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbDimensionGroup",
                table: "DbDimensionGroup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dimensions_DbDimensionGroup_DimensionGroupId",
                table: "Dimensions",
                column: "DimensionGroupId",
                principalTable: "DbDimensionGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
