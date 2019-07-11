using Newtonsoft.Json;
using Metier.Entities;

namespace Wize.Models
{
    public class FormationViewModel
    {
        //DomaineFormation
        [JsonProperty(PropertyName = "domaine-formation")]
        public DomaineFormationViewModel domaineFormation { get; set; }
        //TEXT(1,255) non nul
        [JsonProperty(PropertyName = "intitule-formation")]
        public string intituleFormation { get; set; }
        //TEXT(1,3000) non nul
        [JsonProperty(PropertyName = "objectif-formation")]
        public string objectifFormation { get; set; }
        //TEXT(1,3000) non nul
        [JsonProperty(PropertyName = "resultat-attendus")]
        public string resultatsAttendus { get; set; }
        //TEXT(1,3000) non nul
        [JsonProperty(PropertyName = "contenu-formation")]
        public string contenuFormation { get; set; }
        //CODE(dict-boolean) non nul
        [JsonProperty(PropertyName = "certifiante")]
        public bool certifiante { get; set; }
        //coordonnees non nul
        [JsonProperty(PropertyName = "contact-formation")]
        public CoordonneesViewModel contactFormation { get; set; }
        //CODE(dict-type-parcours) non nul
        [JsonProperty(PropertyName = "parcours-de-formation")]
        public CodeViewModel parcoursDeFormation { get; set; }
        //CODE(dict-niveaux) non nul
        [JsonProperty(PropertyName = "code-niveau-entree")]
        public CodeViewModel codeNiveauEntree { get; set; }
        //CODE(dict-AIS)
        [JsonProperty(PropertyName = "objectif-general-formation")]
        public CodeViewModel objectifGeneralFormation { get; set; }
        //certification
        [JsonProperty(PropertyName = "certification")]
        public CertificationViewModel certification { get; set; }
        //web
        [JsonProperty(PropertyName = "url-formation")]
        public WebViewModel urlFormation { get; set; }
        //action
        [JsonProperty(PropertyName = "action")]
        public ActionViewModel action { get; set; }
        //organisme-formation-responsable
        [JsonProperty(PropertyName = "organisme-formation-responsable")]
        public OrganismeFormationResponsableViewModel organismeFormationResponsable { get; set; }
        //CODE(dict-niveaux)
        [JsonProperty(PropertyName = "code-niveau-sortie")]
        public CodeViewModel codeNiveauSortie { get; set; } 
        //TEXT(1,3000)
        [JsonProperty(PropertyName = "identifiant-module")]
        public string identifiantModule { get; set; }
        //CODE(dict-type-positionnement)
        [JsonProperty(PropertyName = "positionnement")]
        public CodeViewModel positionnement { get; set; }
        //sous-module
        [JsonProperty(PropertyName = "sous-module")]
        public SousModuleViewModel sousModule { get; set; }
        //modules-prerequis
        [JsonProperty(PropertyName = "modules-prerequis")]
        public ModulesPrerequisViewModel modulesPrerequis { get; set; }
        //INT
        [JsonProperty(PropertyName = "credits-Ects")]
        public int creditsEcts { get; set; }
        //BOOL
        [JsonProperty(PropertyName = "eligibilite-Cpf")]
        public bool eligibiliteCpf { get; set; }
        //TEXT
        [JsonProperty(PropertyName = "validations")]
        public string validations { get; set; }

        public Formation formationViewModelToFormation()
        {
            var formation = new Formation();
            return formation;
        }
    }
}
