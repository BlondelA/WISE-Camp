using Newtonsoft.Json;

namespace Wize.Models
{
    public class SessionViewModel
    {
        // periode 
        [JsonProperty(PropertyName = "periode")]
        public PeriodeViewModel periode { get; set; }
        // adresse
        [JsonProperty(PropertyName = "adresse-inscription")]
        public AdresseViewModel adresseInscription { get; set; }
        // periode
        [JsonProperty(PropertyName = "periode-inscription")]
        public PeriodeViewModel periodeInscription { get; set; }
        // TEXT(1,255)
        [JsonProperty(PropertyName = "modalite-inscription")]
        public string modaliteInscription { get; set; }
        // CODE(dict-etat-recrutement)
        [JsonProperty(PropertyName = "etat-recrutement")]
        public CodeViewModel etatRecrutement { get; set; }
    }
}
