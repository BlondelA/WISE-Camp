using Newtonsoft.Json;

namespace Wize.Models
{
    public class AdresseViewModel
    {
        // TEXT (1,50)
        [JsonProperty(PropertyName = "ligne")]
        public string ligne { get; set; }
        // TEXT (5,5)
        [JsonProperty(PropertyName = "codepostal")]
        public string codepostal { get; set; }
        // TEXT (1,50)
        [JsonProperty(PropertyName = "ville")]
        public string ville { get; set; }
        // TEXT (2,3)
        [JsonProperty(PropertyName = "departement")]
        public string departement { get; set; }
        // TEXT (5,5)
        [JsonProperty(PropertyName = "code-INSEE-commune")]
        public string codeINSEEcommune { get; set; }
        // TEXT (4,5)
        [JsonProperty(PropertyName = "code-INSEE-canton")]
        public string codeINSEEcanton { get; set; }
        // TEXT (2,2)
        [JsonProperty(PropertyName = "region")]
        public string region { get; set; }
        // TEXT (2,2)
        [JsonProperty(PropertyName = "pays")]
        public string pays { get; set; }
        // geolocalisation
        [JsonProperty(PropertyName = "geolocalisation")]
        public GeolocalisationViewModel geolocalisation { get; set; }
    }
}
