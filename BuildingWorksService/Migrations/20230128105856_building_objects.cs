using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingWorksService.Migrations
{
    public partial class building_objects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.RenameColumn(
                name: "TownCode",
                table: "Streets",
                newName: "TownId");

            migrationBuilder.RenameColumn(
                name: "StreetCode",
                table: "Streets",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Streets_TownCode",
                table: "Streets",
                newName: "IX_Streets_TownId");

            migrationBuilder.RenameColumn(
                name: "RegionCode",
                table: "Regions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TownCode",
                table: "ObjectAddress",
                newName: "TownId");

            migrationBuilder.RenameColumn(
                name: "StreetCode",
                table: "ObjectAddress",
                newName: "StreetId");

            migrationBuilder.RenameColumn(
                name: "RegionCode",
                table: "ObjectAddress",
                newName: "RegionId");

            migrationBuilder.RenameColumn(
                name: "AddressCode",
                table: "ObjectAddress",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectAddress_TownCode",
                table: "ObjectAddress",
                newName: "IX_ObjectAddress_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectAddress_StreetCode",
                table: "ObjectAddress",
                newName: "IX_ObjectAddress_StreetId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectAddress_RegionCode",
                table: "ObjectAddress",
                newName: "IX_ObjectAddress_RegionId");

            migrationBuilder.RenameColumn(
                name: "TownCode",
                table: "BuildingObject",
                newName: "TownId");

            migrationBuilder.RenameColumn(
                name: "StreetCode",
                table: "BuildingObject",
                newName: "StreetId");

            migrationBuilder.RenameColumn(
                name: "RegionCode",
                table: "BuildingObject",
                newName: "RegionId");

            migrationBuilder.RenameColumn(
                name: "ObjectId",
                table: "BuildingObject",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingObject_TownCode",
                table: "BuildingObject",
                newName: "IX_BuildingObject_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingObject_StreetCode",
                table: "BuildingObject",
                newName: "IX_BuildingObject_StreetId");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingObject_RegionCode",
                table: "BuildingObject",
                newName: "IX_BuildingObject_RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingObject_Regions_RegionId",
                table: "BuildingObject",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingObject_Streets_StreetId",
                table: "BuildingObject",
                column: "StreetId",
                principalTable: "Streets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingObject_Towns_TownId",
                table: "BuildingObject",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectAddress_Regions_RegionId",
                table: "ObjectAddress",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectAddress_Streets_StreetId",
                table: "ObjectAddress",
                column: "StreetId",
                principalTable: "Streets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectAddress_Towns_TownId",
                table: "ObjectAddress",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Streets_Towns_TownId",
                table: "Streets",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Regions_RegionId",
                table: "Towns",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingObject_Regions_RegionId",
                table: "BuildingObject");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingObject_Streets_StreetId",
                table: "BuildingObject");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingObject_Towns_TownId",
                table: "BuildingObject");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectAddress_Regions_RegionId",
                table: "ObjectAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectAddress_Streets_StreetId",
                table: "ObjectAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectAddress_Towns_TownId",
                table: "ObjectAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Streets_Towns_TownId",
                table: "Streets");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Regions_RegionId",
                table: "Towns");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "Towns",
                newName: "RegionCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Towns",
                newName: "TownCode");

            migrationBuilder.RenameIndex(
                name: "IX_Towns_RegionId",
                table: "Towns",
                newName: "IX_Towns_RegionCode");

            migrationBuilder.RenameColumn(
                name: "TownId",
                table: "Streets",
                newName: "TownCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Streets",
                newName: "StreetCode");

            migrationBuilder.RenameIndex(
                name: "IX_Streets_TownId",
                table: "Streets",
                newName: "IX_Streets_TownCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Regions",
                newName: "RegionCode");

            migrationBuilder.RenameColumn(
                name: "TownId",
                table: "ObjectAddress",
                newName: "TownCode");

            migrationBuilder.RenameColumn(
                name: "StreetId",
                table: "ObjectAddress",
                newName: "StreetCode");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "ObjectAddress",
                newName: "RegionCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ObjectAddress",
                newName: "AddressCode");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectAddress_TownId",
                table: "ObjectAddress",
                newName: "IX_ObjectAddress_TownCode");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectAddress_StreetId",
                table: "ObjectAddress",
                newName: "IX_ObjectAddress_StreetCode");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectAddress_RegionId",
                table: "ObjectAddress",
                newName: "IX_ObjectAddress_RegionCode");

            migrationBuilder.RenameColumn(
                name: "TownId",
                table: "BuildingObject",
                newName: "TownCode");

            migrationBuilder.RenameColumn(
                name: "StreetId",
                table: "BuildingObject",
                newName: "StreetCode");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "BuildingObject",
                newName: "RegionCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BuildingObject",
                newName: "ObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingObject_TownId",
                table: "BuildingObject",
                newName: "IX_BuildingObject_TownCode");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingObject_StreetId",
                table: "BuildingObject",
                newName: "IX_BuildingObject_StreetCode");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingObject_RegionId",
                table: "BuildingObject",
                newName: "IX_BuildingObject_RegionCode");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingObject_Regions_RegionCode",
                table: "BuildingObject",
                column: "RegionCode",
                principalTable: "Regions",
                principalColumn: "RegionCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingObject_Streets_StreetCode",
                table: "BuildingObject",
                column: "StreetCode",
                principalTable: "Streets",
                principalColumn: "StreetCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingObject_Towns_TownCode",
                table: "BuildingObject",
                column: "TownCode",
                principalTable: "Towns",
                principalColumn: "TownCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectAddress_Regions_RegionCode",
                table: "ObjectAddress",
                column: "RegionCode",
                principalTable: "Regions",
                principalColumn: "RegionCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectAddress_Streets_StreetCode",
                table: "ObjectAddress",
                column: "StreetCode",
                principalTable: "Streets",
                principalColumn: "StreetCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectAddress_Towns_TownCode",
                table: "ObjectAddress",
                column: "TownCode",
                principalTable: "Towns",
                principalColumn: "TownCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Streets_Towns_TownCode",
                table: "Streets",
                column: "TownCode",
                principalTable: "Towns",
                principalColumn: "TownCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Regions_RegionCode",
                table: "Towns",
                column: "RegionCode",
                principalTable: "Regions",
                principalColumn: "RegionCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
