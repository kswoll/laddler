using Microsoft.EntityFrameworkCore.Migrations;

namespace Laddler.Api.Migrations
{
    public partial class FleshOutMoreTables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DimensionMilestones_DbDimensionGroup_DimensionGroupId",
                table: "DimensionMilestones");

            migrationBuilder.DropIndex(
                name: "IX_DimensionMilestones_DimensionGroupId",
                table: "DimensionMilestones");

            migrationBuilder.DropColumn(
                name: "DimensionGroupId",
                table: "DimensionMilestones");

            migrationBuilder.AddColumn<int>(
                name: "DimensionGroupId",
                table: "Dimensions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_DimensionGroupId",
                table: "Dimensions",
                column: "DimensionGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dimensions_DbDimensionGroup_DimensionGroupId",
                table: "Dimensions",
                column: "DimensionGroupId",
                principalTable: "DbDimensionGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_DbDimensionGroup_DimensionGroupId",
                table: "Dimensions");

            migrationBuilder.DropIndex(
                name: "IX_Dimensions_DimensionGroupId",
                table: "Dimensions");

            migrationBuilder.DropColumn(
                name: "DimensionGroupId",
                table: "Dimensions");

            migrationBuilder.AddColumn<int>(
                name: "DimensionGroupId",
                table: "DimensionMilestones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DimensionMilestones_DimensionGroupId",
                table: "DimensionMilestones",
                column: "DimensionGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionMilestones_DbDimensionGroup_DimensionGroupId",
                table: "DimensionMilestones",
                column: "DimensionGroupId",
                principalTable: "DbDimensionGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
