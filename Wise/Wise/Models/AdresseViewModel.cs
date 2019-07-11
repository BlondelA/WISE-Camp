using Newtonsoft.Json;
using Metier.Entities;

namespace Wise.Models
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
        
        public Adresse AdresseViewModelToAdresse()
        {
            var adresse = new Adresse();

            var geolocalisation = new Geolocalisation() {
                latitude = this.geolocalisation.latitude,
                longitude = this.geolocalisation.longitude
            };
            
            adresse.codeINSEEcanton = this.codeINSEEcanton;
            adresse.codeINSEEcommune = this.codeINSEEcommune;
            adresse.codepostal = this.codepostal;
            adresse.departement = this.departement;
            adresse.geolocalisation = geolocalisation;
            adresse.ligne = this.ligne;
            adresse.pays = this.pays;
            adresse.region = this.region;
            adresse.ville = this.ville;
            
            return adresse;
        }
    }
}
