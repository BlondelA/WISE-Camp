using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Metier.Migrations
{
    public partial class MyFirstEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeRNCP = table.Column<string>(nullable: true),
                    codeCERTIFINFO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodeModalitePedagogiques",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeModalitePedagogiques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Codes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(nullable: true),
                    cle = table.Column<string>(nullable: true),
                    valeur = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DomaineFormations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeFORMACODE = table.Column<string>(nullable: true),
                    codeNSF = table.Column<string>(nullable: true),
                    codeROME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomaineFormations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Geolocalisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    latitude = table.Column<string>(nullable: true),
                    longitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geolocalisations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModulesPrerequis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    referenceModule = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulesPrerequis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Numtels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numtel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numtels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganismeFinanceurs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeFinanceur = table.Column<int>(nullable: false),
                    nbPlaceFinancees = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganismeFinanceurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Periodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    debut = table.Column<DateTime>(nullable: false),
                    fin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Potentiels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeFORMACODE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potentiels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SousModules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    referenceModule = table.Column<string>(nullable: true),
                    typeModule = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SousModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Webs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    urlWeb = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Webs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ligne = table.Column<string>(nullable: true),
                    codepostal = table.Column<string>(nullable: true),
                    ville = table.Column<string>(nullable: true),
                    departement = table.Column<string>(nullable: true),
                    codeINSEEcommune = table.Column<string>(nullable: true),
                    codeINSEEcanton = table.Column<string>(nullable: true),
                    region = table.Column<string>(nullable: true),
                    pays = table.Column<string>(nullable: true),
                    geolocalisationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresses_Geolocalisations_geolocalisationId",
                        column: x => x.geolocalisationId,
                        principalTable: "Geolocalisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coordonnees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    civilite = table.Column<string>(nullable: true),
                    nom = table.Column<string>(nullable: true),
                    prenom = table.Column<string>(nullable: true),
                    ligne1 = table.Column<string>(nullable: true),
                    ligne2 = table.Column<string>(nullable: true),
                    ligne3 = table.Column<string>(nullable: true),
                    courriel = table.Column<string>(nullable: true),
                    adresseId = table.Column<int>(nullable: true),
                    telfixId = table.Column<int>(nullable: true),
                    portableId = table.Column<int>(nullable: true),
                    faxId = table.Column<int>(nullable: true),
                    webId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordonnees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordonnees_Adresses_adresseId",
                        column: x => x.adresseId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coordonnees_Numtels_faxId",
                        column: x => x.faxId,
                        principalTable: "Numtels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coordonnees_Numtels_portableId",
                        column: x => x.portableId,
                        principalTable: "Numtels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coordonnees_Numtels_telfixId",
                        column: x => x.telfixId,
                        principalTable: "Numtels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coordonnees_Webs_webId",
                        column: x => x.webId,
                        principalTable: "Webs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrganismeFormateurs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    siret = table.Column<string>(nullable: true),
                    raisonSociale = table.Column<string>(nullable: true),
                    contactOrganismeId = table.Column<int>(nullable: true),
                    potentielId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganismeFormateurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganismeFormateurs_Coordonnees_contactOrganismeId",
                        column: x => x.contactOrganismeId,
                        principalTable: "Coordonnees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganismeFormateurs_Potentiels_potentielId",
                        column: x => x.potentielId,
                        principalTable: "Potentiels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrganismeFormationResponsables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    siret = table.Column<string>(nullable: true),
                    raisonSociale = table.Column<string>(nullable: true),
                    contactOrganismeId = table.Column<int>(nullable: true),
                    potentielId = table.Column<int>(nullable: true),
                    numeroActivite = table.Column<string>(nullable: true),
                    nomOrganisme = table.Column<string>(nullable: true),
                    coordonneesId = table.Column<int>(nullable: true),
                    renseignementsSpecifiques = table.Column<string>(nullable: true),
                    agreementDatadock = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganismeFormationResponsables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganismeFormationResponsables_Coordonnees_contactOrganismeId",
                        column: x => x.contactOrganismeId,
                        principalTable: "Coordonnees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganismeFormationResponsables_Coordonnees_coordonneesId",
                        column: x => x.coordonneesId,
                        principalTable: "Coordonnees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganismeFormationResponsables_Potentiels_potentielId",
                        column: x => x.potentielId,
                        principalTable: "Potentiels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rythmeFormation = table.Column<string>(nullable: true),
                    codePublicVise = table.Column<string>(nullable: true),
                    modaliteAlternance = table.Column<string>(nullable: true),
                    conditionsSpecifiques = table.Column<string>(nullable: true),
                    lieuFormationId = table.Column<int>(nullable: true),
                    restauration = table.Column<string>(nullable: true),
                    hebergement = table.Column<string>(nullable: true),
                    transport = table.Column<string>(nullable: true),
                    accesHandicapes = table.Column<string>(nullable: true),
                    langueFormation = table.Column<string>(nullable: true),
                    modlitesRecrutement = table.Column<string>(nullable: true),
                    modalitesPedagogiques = table.Column<string>(nullable: true),
                    codeModalitePedagogiqueId = table.Column<int>(nullable: true),
                    fraisRestants = table.Column<string>(nullable: true),
                    infosPerimetreRecrutement = table.Column<string>(nullable: true),
                    prixHoraireTTC = table.Column<float>(nullable: false),
                    prixTotalTTC = table.Column<float>(nullable: false),
                    dureeIndicative = table.Column<string>(nullable: true),
                    nombreHeuresCentre = table.Column<int>(nullable: false),
                    nombreHeuresEntreprise = table.Column<int>(nullable: false),
                    nombreHeuresTotal = table.Column<int>(nullable: false),
                    detailConditionsPriseEnCharge = table.Column<string>(nullable: true),
                    dureeConventionnee = table.Column<int>(nullable: false),
                    organismeFormateurId = table.Column<int>(nullable: true),
                    organismeFinanceurId = table.Column<int>(nullable: true),
                    financementFormation = table.Column<string>(nullable: true),
                    nbPlaces = table.Column<int>(nullable: false),
                    moyensPedagogiques = table.Column<string>(nullable: true),
                    responsableEngagementId = table.Column<int>(nullable: true),
                    nombreHeuresCm = table.Column<int>(nullable: false),
                    nombreHeuresTd = table.Column<int>(nullable: false),
                    nombreHeuresTpTuteure = table.Column<int>(nullable: false),
                    nombreHeuresTpNonTuteure = table.Column<int>(nullable: false),
                    nombreHeuresPersonnel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actions_CodeModalitePedagogiques_codeModalitePedagogiqueId",
                        column: x => x.codeModalitePedagogiqueId,
                        principalTable: "CodeModalitePedagogiques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Actions_Coordonnees_lieuFormationId",
                        column: x => x.lieuFormationId,
                        principalTable: "Coordonnees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Actions_OrganismeFinanceurs_organismeFinanceurId",
                        column: x => x.organismeFinanceurId,
                        principalTable: "OrganismeFinanceurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Actions_OrganismeFormateurs_organismeFormateurId",
                        column: x => x.organismeFormateurId,
                        principalTable: "OrganismeFormateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Actions_Coordonnees_responsableEngagementId",
                        column: x => x.responsableEngagementId,
                        principalTable: "Coordonnees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Formations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    domaineFormationId = table.Column<int>(nullable: true),
                    intituleFormation = table.Column<string>(nullable: true),
                    objectifFormation = table.Column<string>(nullable: true),
                    resultatsAttendus = table.Column<string>(nullable: true),
                    contenuFormation = table.Column<string>(nullable: true),
                    certifiante = table.Column<bool>(nullable: false),
                    contactFormationId = table.Column<int>(nullable: true),
                    codeNiveauEntree = table.Column<int>(nullable: false),
                    certificationId = table.Column<int>(nullable: true),
                    urlFormationId = table.Column<int>(nullable: true),
                    actionId = table.Column<int>(nullable: true),
                    organismeFormationResponsableId = table.Column<int>(nullable: true),
                    identifiantModule = table.Column<string>(nullable: true),
                    sousModuleId = table.Column<int>(nullable: true),
                    modulesPrerequisId = table.Column<int>(nullable: true),
                    creditsEcts = table.Column<int>(nullable: false),
                    eligibiliteCpf = table.Column<bool>(nullable: false),
                    validations = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formations_Actions_actionId",
                        column: x => x.actionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Formations_Certifications_certificationId",
                        column: x => x.certificationId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Formations_Coordonnees_contactFormationId",
                        column: x => x.contactFormationId,
                        principalTable: "Coordonnees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Formations_DomaineFormations_domaineFormationId",
                        column: x => x.domaineFormationId,
                        principalTable: "DomaineFormations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Formations_ModulesPrerequis_modulesPrerequisId",
                        column: x => x.modulesPrerequisId,
                        principalTable: "ModulesPrerequis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Formations_OrganismeFormationResponsables_organismeFormation~",
                        column: x => x.organismeFormationResponsableId,
                        principalTable: "OrganismeFormationResponsables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Formations_SousModules_sousModuleId",
                        column: x => x.sousModuleId,
                        principalTable: "SousModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Formations_Webs_urlFormationId",
                        column: x => x.urlFormationId,
                        principalTable: "Webs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    periodeId = table.Column<int>(nullable: true),
                    adresseInscriptionId = table.Column<int>(nullable: true),
                    periodeInscriptionId = table.Column<int>(nullable: true),
                    modaliteInscription = table.Column<string>(nullable: true),
                    ActionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Adresses_adresseInscriptionId",
                        column: x => x.adresseInscriptionId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Periodes_periodeId",
                        column: x => x.periodeId,
                        principalTable: "Periodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Periodes_periodeInscriptionId",
                        column: x => x.periodeInscriptionId,
                        principalTable: "Periodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actions_codeModalitePedagogiqueId",
                table: "Actions",
                column: "codeModalitePedagogiqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_lieuFormationId",
                table: "Actions",
                column: "lieuFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_organismeFinanceurId",
                table: "Actions",
                column: "organismeFinanceurId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_organismeFormateurId",
                table: "Actions",
                column: "organismeFormateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_responsableEngagementId",
                table: "Actions",
                column: "responsableEngagementId");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_geolocalisationId",
                table: "Adresses",
                column: "geolocalisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnees_adresseId",
                table: "Coordonnees",
                column: "adresseId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnees_faxId",
                table: "Coordonnees",
                column: "faxId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnees_portableId",
                table: "Coordonnees",
                column: "portableId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnees_telfixId",
                table: "Coordonnees",
                column: "telfixId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnees_webId",
                table: "Coordonnees",
                column: "webId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_actionId",
                table: "Formations",
                column: "actionId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_certificationId",
                table: "Formations",
                column: "certificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_contactFormationId",
                table: "Formations",
                column: "contactFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_domaineFormationId",
                table: "Formations",
                column: "domaineFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_modulesPrerequisId",
                table: "Formations",
                column: "modulesPrerequisId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_organismeFormationResponsableId",
                table: "Formations",
                column: "organismeFormationResponsableId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_sousModuleId",
                table: "Formations",
                column: "sousModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_urlFormationId",
                table: "Formations",
                column: "urlFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganismeFormateurs_contactOrganismeId",
                table: "OrganismeFormateurs",
                column: "contactOrganismeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganismeFormateurs_potentielId",
                table: "OrganismeFormateurs",
                column: "potentielId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganismeFormationResponsables_contactOrganismeId",
                table: "OrganismeFormationResponsables",
                column: "contactOrganismeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganismeFormationResponsables_coordonneesId",
                table: "OrganismeFormationResponsables",
                column: "coordonneesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganismeFormationResponsables_potentielId",
                table: "OrganismeFormationResponsables",
                column: "potentielId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_ActionId",
                table: "Sessions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_adresseInscriptionId",
                table: "Sessions",
                column: "adresseInscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_periodeId",
                table: "Sessions",
                column: "periodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_periodeInscriptionId",
                table: "Sessions",
                column: "periodeInscriptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Codes");

            migrationBuilder.DropTable(
                name: "Formations");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "DomaineFormations");

            migrationBuilder.DropTable(
                name: "ModulesPrerequis");

            migrationBuilder.DropTable(
                name: "OrganismeFormationResponsables");

            migrationBuilder.DropTable(
                name: "SousModules");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Periodes");

            migrationBuilder.DropTable(
                name: "CodeModalitePedagogiques");

            migrationBuilder.DropTable(
                name: "OrganismeFinanceurs");

            migrationBuilder.DropTable(
                name: "OrganismeFormateurs");

            migrationBuilder.DropTable(
                name: "Coordonnees");

            migrationBuilder.DropTable(
                name: "Potentiels");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "Numtels");

            migrationBuilder.DropTable(
                name: "Webs");

            migrationBuilder.DropTable(
                name: "Geolocalisations");
        }
    }
}
