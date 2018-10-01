using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Laddler.Api.Migrations
{
    public partial class FleshOutMoreTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DimensionMilestones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DimensionGroupId",
                table: "DimensionMilestones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DbDimensionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbDimensionGroup", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DimensionMilestones_DbDimensionGroup_DimensionGroupId",
                table: "DimensionMilestones");

            migrationBuilder.DropTable(
                name: "DbDimensionGroup");

            migrationBuilder.DropIndex(
                name: "IX_DimensionMilestones_DimensionGroupId",
                table: "DimensionMilestones");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DimensionMilestones");

            migrationBuilder.DropColumn(
                name: "DimensionGroupId",
                table: "DimensionMilestones");
        }
    }
}
