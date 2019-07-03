using System.Collections.Generic;

namespace Wize.Models
{
    public class ActionViewModel
        {
        // TEXT (1,3000) non null
        public string rythmeFormation { get; set; }
        // TEXT (1,3000) non null
        public string codePublicVise { get; set; }
        // CODE (dict-boolean) non null
        public CodeViewModel niveauEntreeObligatoire { get; set; }
        // TEXT (1,3000) non null
        public string modaliteAlternance { get; set; }
        // CODE (dict-modalites-enseignement) non null
        public CodeViewModel modaliteEnseignement { get; set; }
        // TEXT (1,3000) non null
        public string conditionsSpecifiques { get; set; }
        // CODE (dict-boolean) non null
        public CodeViewModel priseEnChargeFraisPossible { get; set; }
        // Coordonnées
        public CoordonneesViewModel lieuFormation { get; set; }
        // CODE (dict-modalites-es) non null
        public CodeViewModel modaliteEntreesSorties { get; set; }
        // Session
        public List<SessionViewModel> session { get; set; }
        // TEXT (1,250)
        public string restauration { get; set; }
        // TEXT (1,250)
        public string hebergement { get; set; }
        // TEXT (1,250)
        public string transport { get; set; }
        // TEXT (1,250)
        public string accesHandicapes { get; set; }
        // TEXT (2,2)
        public string langueFormation { get; set; }
        // TEXT (0,200)
        public string modlitesRecrutement { get; set; }
        // TEXT (0,200)
        public string modalitesPedagogiques { get; set; }
        //code modalité pédagogique
        public CodeModalitePedagogiqueViewModel codeModalitePedagogique { get; set; }
        // TEXT (0,200)
        public string fraisRestants { get; set; }
        // CODE(dict-perimetre-recrutement)
        public CodeViewModel codePerimetreRecrutement { get; set; }
        // TEXT (0,50)
        public string infosPerimetreRecrutement { get; set; }
        // TEXT (1,6)
        public float prixHoraireTTC { get; set; }
        // TEXT (1,10)
        public float prixTotalTTC { get; set; }
        // TEXT (0,150)
        public string dureeIndicative { get; set; }
        // INT
        public int nombreHeuresCentre { get; set; }
        // INT
        public int nombreHeuresEntreprise { get; set; }
        // INT
        public int nombreHeuresTotal { get; set; }
        // TEXT(1,600)
        public string detailConditionsPriseEnCharge { get; set; }
        // CODE (dict-boolean)
        public CodeViewModel conventionnement { get; set; }
        // INT
        public int dureeConventionnee { get; set; }
        // Organisme formateur
        public OrganismeFormateurViewModel organismeFormateur { get; set; }
        // Organisme financeur
        public OrganismeFinanceurViewModel organismeFinanceur { get; set; }
        // TEXT
        public string financementFormation { get; set; }
        // INT
        public int nbPlaces { get; set; }
        // TEXT
        public string moyensPedagogiques { get; set; }
        // Coordonnées
        public  CoordonneesViewModel responsableEngagement { get; set; }
        // INT
        public int nombreHeuresCm { get; set; }
        // INT
        public int nombreHeuresTd { get; set; }
        // INT
        public int nombreHeuresTpTuteure { get; set; }
        // INT
        public int nombreHeuresTpNonTuteure { get; set; }
        // INT
        public int nombreHeuresPersonnel { get; set; }
    }
}
