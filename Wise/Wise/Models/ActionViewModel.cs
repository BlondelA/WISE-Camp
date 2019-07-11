using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wise.Models
{
    public class ActionViewModel
    {
        // TEXT (1,3000) non null
        [JsonProperty(PropertyName = "rythme-formation")]
        public string rythmeFormation { get; set; }
        // TEXT (1,3000) non null
        [JsonProperty(PropertyName = "code-public-vise")]
        public string codePublicVise { get; set; }
        // CODE (dict-boolean) non null
        [JsonProperty(PropertyName = "niveau-entree-obligatoire")]
        public CodeViewModel niveauEntreeObligatoire { get; set; }
        // TEXT (1,3000) non null
        [JsonProperty(PropertyName = "modalite-alternance")]
        public string modaliteAlternance { get; set; }
        // CODE (dict-modalites-enseignement) non null
        [JsonProperty(PropertyName = "dict-modalites-enseignement")]
        public CodeViewModel modaliteEnseignement { get; set; }
        // TEXT (1,3000) non null
        [JsonProperty(PropertyName = "conditions-specifiques")]
        public string conditionsSpecifiques { get; set; }
        // CODE (dict-boolean) non null
        [JsonProperty(PropertyName = "prise-en-charge-frais-possible")]
        public CodeViewModel priseEnChargeFraisPossible { get; set; }
        // Coordonnées
        [JsonProperty(PropertyName = "lieu-formation")]
        public CoordonneesViewModel lieuFormation { get; set; }
        // CODE (dict-modalites-es) non null
        [JsonProperty(PropertyName = "modalite-entrees-sorties")]
        public CodeViewModel modaliteEntreesSorties { get; set; }
        // Session
        [JsonProperty(PropertyName = "session")]
        public List<SessionViewModel> session { get; set; }
        // TEXT (1,250)
        [JsonProperty(PropertyName = "restauration")]
        public string restauration { get; set; }
        // TEXT (1,250)
        [JsonProperty(PropertyName = "hebergement")]
        public string hebergement { get; set; }
        // TEXT (1,250)
        [JsonProperty(PropertyName = "transport")]
        public string transport { get; set; }
        // TEXT (1,250)
        [JsonProperty(PropertyName = "acces-handicapes")]
        public string accesHandicapes { get; set; }
        // TEXT (2,2)
        [JsonProperty(PropertyName = "langue-formation")]
        public string langueFormation { get; set; }
        // TEXT (0,200)
        [JsonProperty(PropertyName = "modalites-recrutement")]
        public string modlitesRecrutement { get; set; }
        // TEXT (0,200)
        [JsonProperty(PropertyName = "modalites-pedagogiques")]
        public string modalitesPedagogiques { get; set; }
        //code modalité pédagogique
        [JsonProperty(PropertyName = "code-modalite-pedagogique")]
        public CodeModalitePedagogiqueViewModel codeModalitePedagogique { get; set; }
        // TEXT (0,200)
        [JsonProperty(PropertyName = "frais-restants")]
        public string fraisRestants { get; set; }
        // CODE(dict-perimetre-recrutement)
        [JsonProperty(PropertyName = "code-perimetre-recrutement")]
        public CodeViewModel codePerimetreRecrutement { get; set; }
        // TEXT (0,50)
        [JsonProperty(PropertyName = "infos-perimetre-recrutement")]
        public string infosPerimetreRecrutement { get; set; }
        // TEXT (1,6)
        [JsonProperty(PropertyName = "prix-horaire-TTC")]
        public float prixHoraireTTC { get; set; }
        // TEXT (1,10)
        [JsonProperty(PropertyName = "prix-totalTTC")]
        public float prixTotalTTC { get; set; }
        // TEXT (0,150)
        [JsonProperty(PropertyName = "duree-indicative")]
        public string dureeIndicative { get; set; }
        // INT
        [JsonProperty(PropertyName = "nombre-heures-centre")]
        public int nombreHeuresCentre { get; set; }
        // INT
        [JsonProperty(PropertyName = "nombre-heures-entreprise")]
        public int nombreHeuresEntreprise { get; set; }
        // INT
        [JsonProperty(PropertyName = "nombre-heures-total")]
        public int nombreHeuresTotal { get; set; }
        // TEXT(1,600)
        [JsonProperty(PropertyName = "detail-conditions-prise-en-charge")]
        public string detailConditionsPriseEnCharge { get; set; }
        // CODE (dict-boolean)
        [JsonProperty(PropertyName = "conventionnement")]
        public CodeViewModel conventionnement { get; set; }
        // INT
        [JsonProperty(PropertyName = "duree-conventionnee")]
        public int dureeConventionnee { get; set; }
        // Organisme formateur
        [JsonProperty(PropertyName = "organisme-formateur")]
        public OrganismeFormateurViewModel organismeFormateur { get; set; }
        // Organisme financeur
        [JsonProperty(PropertyName = "organisme-financeur")]
        public OrganismeFinanceurViewModel organismeFinanceur { get; set; }
        // TEXT
        [JsonProperty(PropertyName = "financement-formation")]
        public string financementFormation { get; set; }
        // INT
        [JsonProperty(PropertyName = "nb-places")]
        public int nbPlaces { get; set; }
        // TEXT
        [JsonProperty(PropertyName = "moyens-pedagogiques")]
        public string moyensPedagogiques { get; set; }
        // Coordonnées
        [JsonProperty(PropertyName = "responsable-engagement")]
        public CoordonneesViewModel responsableEngagement { get; set; }
        // INT
        [JsonProperty(PropertyName = "nombre-heures-cm")]
        public int nombreHeuresCm { get; set; }
        // INT
        [JsonProperty(PropertyName = "nombre-heures-td")]
        public int nombreHeuresTd { get; set; }
        // INT
        [JsonProperty(PropertyName = "nombre-heures-tp-tuteure")]
        public int nombreHeuresTpTuteure { get; set; }
        // INT
        [JsonProperty(PropertyName = "nombre-heures-tp-non-tuteure")]
        public int nombreHeuresTpNonTuteure { get; set; }
        // INT
        [JsonProperty(PropertyName = "nombre-heures-personnel")]
        public int nombreHeuresPersonnel { get; set; }
    }
}
