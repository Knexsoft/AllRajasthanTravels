using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllRajasthan.DAL.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    PackageName = table.Column<string>(nullable: true),
                    Overview = table.Column<string>(type: "ntext", nullable: false),
                    Exclusions = table.Column<string>(type: "ntext", nullable: false),
                    CancellationPolicy = table.Column<string>(type: "ntext", nullable: false),
                    Notes = table.Column<string>(type: "ntext", nullable: true),
                    Images = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TotalDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Itineraries",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    PackageID = table.Column<Guid>(nullable: false),
                    Day = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itineraries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Itineraries_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    PackageID = table.Column<Guid>(nullable: false),
                    PackageTypeName = table.Column<string>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Inclusions = table.Column<string>(type: "ntext", nullable: false),
                    Sort = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PackageTypes_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Itineraries_PackageID",
                table: "Itineraries",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageName",
                table: "Packages",
                column: "PackageName",
                unique: true,
                filter: "[PackageName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PackageTypes_PackageID",
                table: "PackageTypes",
                column: "PackageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Itineraries");

            migrationBuilder.DropTable(
                name: "PackageTypes");

            migrationBuilder.DropTable(
                name: "Packages");
        }
    }
}
