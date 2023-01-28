using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingWorksService.Migrations
{
    public partial class plans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlanCode",
                table: "Plans",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlansDetails_Plans_PlanId",
                table: "PlansDetails",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlansDetails_Plans_PlanId",
                table: "PlansDetails");

            migrationBuilder.RenameColumn(
                name: "PlanId",
                table: "PlansDetails",
                newName: "PlanCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PlansDetails",
                newName: "PlanDetailCode");

            migrationBuilder.RenameIndex(
                name: "IX_PlansDetails_PlanId",
                table: "PlansDetails",
                newName: "IX_PlansDetails_PlanCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Plans",
                newName: "PlanCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PlansDetails_Plans_PlanCode",
                table: "PlansDetails",
                column: "PlanCode",
                principalTable: "Plans",
                principalColumn: "PlanCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
