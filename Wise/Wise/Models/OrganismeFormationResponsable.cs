using Newtonsoft.Json;

namespace Wise.Models
{
    public class OrganismeFormationResponsableViewModel : OrganismeViewModel
    {
        // TEXT (11,11) non null
        [JsonProperty(PropertyName = "numero-activite")]
        public string numeroActivite { get; set; }
        // TEXT (11,250) non null
        [JsonProperty(PropertyName = "nom-organisme")]
        public string nomOrganisme { get; set; }
        // Cooredonnées
        [JsonProperty(PropertyName = "coordonnees")]
        public CoordonneesViewModel coordonnees { get; set;}
        // TEXT (0,3000)
        [JsonProperty(PropertyName = "renseignements-specifiques")]
        public string renseignementsSpecifiques { get; set; }
        // TEXT
        [JsonProperty(PropertyName = "agreement-datadock")]
        public string agreementDatadock { get; set; }
    }
}
