using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionEleve1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etablissement",
                columns: table => new
                {
                    EtablissementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EtablissementName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement", x => x.EtablissementId);
                });

            migrationBuilder.CreateTable(
                name: "Eleve",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EtablissementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eleve_Etablissement_EtablissementId",
                        column: x => x.EtablissementId,
                        principalTable: "Etablissement",
                        principalColumn: "EtablissementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_EtablissementId",
                table: "Eleve",
                column: "EtablissementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eleve");

            migrationBuilder.DropTable(
                name: "Etablissement");
        }
    }
}
