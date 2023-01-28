using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingWorksService.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PricePerOne = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Measure = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialCode);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AdditionalData = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderCode);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RegionName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionCode);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UnregisteredUsersCodes",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnregisteredUsersCodes", x => x.Code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserCode);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Conditions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractCode);
                    table.ForeignKey(
                        name: "FK_Contracts_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "ProviderCode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    TownCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TownName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.TownCode);
                    table.ForeignKey(
                        name: "FK_Towns_Regions_RegionCode",
                        column: x => x.RegionCode,
                        principalTable: "Regions",
                        principalColumn: "RegionCode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContractMaterial",
                columns: table => new
                {
                    ContractsContractCode = table.Column<int>(type: "int", nullable: false),
                    MaterialsMaterialCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractMaterial", x => new { x.ContractsContractCode, x.MaterialsMaterialCode });
                    table.ForeignKey(
                        name: "FK_ContractMaterial_Contracts_ContractsContractCode",
                        column: x => x.ContractsContractCode,
                        principalTable: "Contracts",
                        principalColumn: "ContractCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractMaterial_Materials_MaterialsMaterialCode",
                        column: x => x.MaterialsMaterialCode,
                        principalTable: "Materials",
                        principalColumn: "MaterialCode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    StreetCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StreetName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TownCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.StreetCode);
                    table.ForeignKey(
                        name: "FK_Streets_Towns_TownCode",
                        column: x => x.TownCode,
                        principalTable: "Towns",
                        principalColumn: "TownCode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BuildingObject",
                columns: table => new
                {
                    ObjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ObjectName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObjectType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObjectCustomer = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionCode = table.Column<int>(type: "int", nullable: false),
                    TownCode = table.Column<int>(type: "int", nullable: false),
                    StreetCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingObject", x => x.ObjectId);
                    table.ForeignKey(
                        name: "FK_BuildingObject_Regions_RegionCode",
                        column: x => x.RegionCode,
                        principalTable: "Regions",
                        principalColumn: "RegionCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingObject_Streets_StreetCode",
                        column: x => x.StreetCode,
                        principalTable: "Streets",
                        principalColumn: "StreetCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingObject_Towns_TownCode",
                        column: x => x.TownCode,
                        principalTable: "Towns",
                        principalColumn: "TownCode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ObjectAddress",
                columns: table => new
                {
                    AddressCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RegionCode = table.Column<int>(type: "int", nullable: false),
                    TownCode = table.Column<int>(type: "int", nullable: false),
                    StreetCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectAddress", x => x.AddressCode);
                    table.ForeignKey(
                        name: "FK_ObjectAddress_Regions_RegionCode",
                        column: x => x.RegionCode,
                        principalTable: "Regions",
                        principalColumn: "RegionCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectAddress_Streets_StreetCode",
                        column: x => x.StreetCode,
                        principalTable: "Streets",
                        principalColumn: "StreetCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectAddress_Towns_TownCode",
                        column: x => x.TownCode,
                        principalTable: "Towns",
                        principalColumn: "TownCode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContractsByMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BuildingObjectId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractsByMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractsByMaterials_BuildingObject_BuildingObjectId",
                        column: x => x.BuildingObjectId,
                        principalTable: "BuildingObject",
                        principalColumn: "ObjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractsByMaterials_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "ContractCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractsByMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialCode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    PlanCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompleteTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PathToImage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.PlanCode);
                    table.ForeignKey(
                        name: "FK_Plans_BuildingObject_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "BuildingObject",
                        principalColumn: "ObjectId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlansDetails",
                columns: table => new
                {
                    PlanDetailCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkPart = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Price = table.Column<float>(type: "float", nullable: false),
                    PlanCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlansDetails", x => x.PlanDetailCode);
                    table.ForeignKey(
                        name: "FK_PlansDetails_Plans_PlanCode",
                        column: x => x.PlanCode,
                        principalTable: "Plans",
                        principalColumn: "PlanCode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Brigades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ObjectId = table.Column<int>(type: "int", nullable: false),
                    BrigadierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brigades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brigades_BuildingObject_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "BuildingObject",
                        principalColumn: "ObjectId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartWorkDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WorkerPost = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BrigadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workers_Brigades_BrigadeId",
                        column: x => x.BrigadeId,
                        principalTable: "Brigades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkersSalaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BaseSalary = table.Column<float>(type: "float", nullable: false),
                    Experience = table.Column<float>(type: "float", nullable: false),
                    ChildrenCount = table.Column<int>(type: "int", nullable: false),
                    WorkedDays = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<float>(type: "float", nullable: false),
                    WorkerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkersSalaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkersSalaries_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Brigades_BrigadierId",
                table: "Brigades",
                column: "BrigadierId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brigades_ObjectId",
                table: "Brigades",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingObject_RegionCode",
                table: "BuildingObject",
                column: "RegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingObject_StreetCode",
                table: "BuildingObject",
                column: "StreetCode");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingObject_TownCode",
                table: "BuildingObject",
                column: "TownCode");

            migrationBuilder.CreateIndex(
                name: "IX_ContractMaterial_MaterialsMaterialCode",
                table: "ContractMaterial",
                column: "MaterialsMaterialCode");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ProviderId",
                table: "Contracts",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractsByMaterials_BuildingObjectId",
                table: "ContractsByMaterials",
                column: "BuildingObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractsByMaterials_ContractId",
                table: "ContractsByMaterials",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractsByMaterials_MaterialId",
                table: "ContractsByMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectAddress_RegionCode",
                table: "ObjectAddress",
                column: "RegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectAddress_StreetCode",
                table: "ObjectAddress",
                column: "StreetCode");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectAddress_TownCode",
                table: "ObjectAddress",
                column: "TownCode");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_ObjectId",
                table: "Plans",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PlansDetails_PlanCode",
                table: "PlansDetails",
                column: "PlanCode");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_TownCode",
                table: "Streets",
                column: "TownCode");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_RegionCode",
                table: "Towns",
                column: "RegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_BrigadeId",
                table: "Workers",
                column: "BrigadeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkersSalaries_WorkerId",
                table: "WorkersSalaries",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brigades_Workers_BrigadierId",
                table: "Brigades",
                column: "BrigadierId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brigades_BuildingObject_ObjectId",
                table: "Brigades");

            migrationBuilder.DropForeignKey(
                name: "FK_Brigades_Workers_BrigadierId",
                table: "Brigades");

            migrationBuilder.DropTable(
                name: "ContractMaterial");

            migrationBuilder.DropTable(
                name: "ContractsByMaterials");

            migrationBuilder.DropTable(
                name: "ObjectAddress");

            migrationBuilder.DropTable(
                name: "PlansDetails");

            migrationBuilder.DropTable(
                name: "UnregisteredUsersCodes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkersSalaries");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "BuildingObject");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Brigades");
        }
    }
}
