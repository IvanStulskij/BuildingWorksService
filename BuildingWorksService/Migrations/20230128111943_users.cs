using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingWorksService.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserCode",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "UnregisteredUsersCodes",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UnregisteredUsersCodes",
                newName: "Code");
        }
    }
}
