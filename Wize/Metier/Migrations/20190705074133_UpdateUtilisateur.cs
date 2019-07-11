using Microsoft.EntityFrameworkCore.Migrations;

namespace Metier.Migrations
{
    public partial class UpdateUtilisateur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "typeModule",
                table: "SousModules");

            migrationBuilder.DropColumn(
                name: "codeFinanceur",
                table: "OrganismeFinanceurs");

            migrationBuilder.DropColumn(
                name: "codeNiveauEntree",
                table: "Formations");

            migrationBuilder.AddColumn<int>(
                name: "typeModuleId",
                table: "SousModules",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "etatRecrutementId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "codeFinanceurId",
                table: "OrganismeFinanceurs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "codeNiveauEntreeId",
                table: "Formations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "codeNiveauSortieId",
                table: "Formations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "objectifGeneralFormationId",
                table: "Formations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "parcoursDeFormationId",
                table: "Formations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "positionnementId",
                table: "Formations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "codePerimetreRecrutementId",
                table: "Actions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "conventionnementId",
                table: "Actions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "modaliteEnseignementId",
                table: "Actions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "modaliteEntreesSortiesId",
                table: "Actions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "niveauEntreeObligatoireId",
                table: "Actions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "priseEnChargeFraisPossibleId",
                table: "Actions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SousModules_typeModuleId",
                table: "SousModules",
                column: "typeModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_etatRecrutementId",
                table: "Sessions",
                column: "etatRecrutementId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganismeFinanceurs_codeFinanceurId",
                table: "OrganismeFinanceurs",
                column: "codeFinanceurId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_codeNiveauEntreeId",
                table: "Formations",
                column: "codeNiveauEntreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_codeNiveauSortieId",
                table: "Formations",
                column: "codeNiveauSortieId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_objectifGeneralFormationId",
                table: "Formations",
                column: "objectifGeneralFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_parcoursDeFormationId",
                table: "Formations",
                column: "parcoursDeFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_positionnementId",
                table: "Formations",
                column: "positionnementId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_codePerimetreRecrutementId",
                table: "Actions",
                column: "codePerimetreRecrutementId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_conventionnementId",
                table: "Actions",
                column: "conventionnementId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_modaliteEnseignementId",
                table: "Actions",
                column: "modaliteEnseignementId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_modaliteEntreesSortiesId",
                table: "Actions",
                column: "modaliteEntreesSortiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_niveauEntreeObligatoireId",
                table: "Actions",
                column: "niveauEntreeObligatoireId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_priseEnChargeFraisPossibleId",
                table: "Actions",
                column: "priseEnChargeFraisPossibleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Codes_codePerimetreRecrutementId",
                table: "Actions",
                column: "codePerimetreRecrutementId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Codes_conventionnementId",
                table: "Actions",
                column: "conventionnementId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Codes_modaliteEnseignementId",
                table: "Actions",
                column: "modaliteEnseignementId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Codes_modaliteEntreesSortiesId",
                table: "Actions",
                column: "modaliteEntreesSortiesId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Codes_niveauEntreeObligatoireId",
                table: "Actions",
                column: "niveauEntreeObligatoireId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Codes_priseEnChargeFraisPossibleId",
                table: "Actions",
                column: "priseEnChargeFraisPossibleId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Codes_codeNiveauEntreeId",
                table: "Formations",
                column: "codeNiveauEntreeId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Codes_codeNiveauSortieId",
                table: "Formations",
                column: "codeNiveauSortieId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Codes_objectifGeneralFormationId",
                table: "Formations",
                column: "objectifGeneralFormationId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Codes_parcoursDeFormationId",
                table: "Formations",
                column: "parcoursDeFormationId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Codes_positionnementId",
                table: "Formations",
                column: "positionnementId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganismeFinanceurs_Codes_codeFinanceurId",
                table: "OrganismeFinanceurs",
                column: "codeFinanceurId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Codes_etatRecrutementId",
                table: "Sessions",
                column: "etatRecrutementId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SousModules_Codes_typeModuleId",
                table: "SousModules",
                column: "typeModuleId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Codes_codePerimetreRecrutementId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Codes_conventionnementId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Codes_modaliteEnseignementId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Codes_modaliteEntreesSortiesId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Codes_niveauEntreeObligatoireId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Codes_priseEnChargeFraisPossibleId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Codes_codeNiveauEntreeId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Codes_codeNiveauSortieId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Codes_objectifGeneralFormationId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Codes_parcoursDeFormationId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Codes_positionnementId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganismeFinanceurs_Codes_codeFinanceurId",
                table: "OrganismeFinanceurs");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Codes_etatRecrutementId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_SousModules_Codes_typeModuleId",
                table: "SousModules");

            migrationBuilder.DropIndex(
                name: "IX_SousModules_typeModuleId",
                table: "SousModules");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_etatRecrutementId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_OrganismeFinanceurs_codeFinanceurId",
                table: "OrganismeFinanceurs");

            migrationBuilder.DropIndex(
                name: "IX_Formations_codeNiveauEntreeId",
                table: "Formations");

            migrationBuilder.DropIndex(
                name: "IX_Formations_codeNiveauSortieId",
                table: "Formations");

            migrationBuilder.DropIndex(
                name: "IX_Formations_objectifGeneralFormationId",
                table: "Formations");

            migrationBuilder.DropIndex(
                name: "IX_Formations_parcoursDeFormationId",
                table: "Formations");

            migrationBuilder.DropIndex(
                name: "IX_Formations_positionnementId",
                table: "Formations");

            migrationBuilder.DropIndex(
                name: "IX_Actions_codePerimetreRecrutementId",
                table: "Actions");

            migrationBuilder.DropIndex(
                name: "IX_Actions_conventionnementId",
                table: "Actions");

            migrationBuilder.DropIndex(
                name: "IX_Actions_modaliteEnseignementId",
                table: "Actions");

            migrationBuilder.DropIndex(
                name: "IX_Actions_modaliteEntreesSortiesId",
                table: "Actions");

            migrationBuilder.DropIndex(
                name: "IX_Actions_niveauEntreeObligatoireId",
                table: "Actions");

            migrationBuilder.DropIndex(
                name: "IX_Actions_priseEnChargeFraisPossibleId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "typeModuleId",
                table: "SousModules");

            migrationBuilder.DropColumn(
                name: "etatRecrutementId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "codeFinanceurId",
                table: "OrganismeFinanceurs");

            migrationBuilder.DropColumn(
                name: "codeNiveauEntreeId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "codeNiveauSortieId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "objectifGeneralFormationId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "parcoursDeFormationId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "positionnementId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "codePerimetreRecrutementId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "conventionnementId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "modaliteEnseignementId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "modaliteEntreesSortiesId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "niveauEntreeObligatoireId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "priseEnChargeFraisPossibleId",
                table: "Actions");

            migrationBuilder.AddColumn<int>(
                name: "typeModule",
                table: "SousModules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "codeFinanceur",
                table: "OrganismeFinanceurs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "codeNiveauEntree",
                table: "Formations",
                nullable: false,
                defaultValue: 0);
        }
    }
}
