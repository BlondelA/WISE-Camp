using Newtonsoft.Json;

namespace Wise.Models
{
    public class OrganismeViewModel
    {
        // TEXT (14,14) non null
        [JsonProperty(PropertyName = "SIRET")]
        public string siret { get; set; }
        // TEXT (1,250) non null
        [JsonProperty(PropertyName = "raison-sociale")]
        public string raisonSociale { get; set; }
        // Coordonnées
        [JsonProperty(PropertyName = "contact-organisme")]
        public CoordonneesViewModel contactOrganisme { get; set; }
        // potentiel
        [JsonProperty(PropertyName = "potentiel")]
        public PotentielViewModel potentiel { get; set; }
    }
}
