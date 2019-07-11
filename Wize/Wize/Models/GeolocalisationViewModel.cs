using Newtonsoft.Json;

namespace Wize.Models
{
    public class GeolocalisationViewModel
    {
        // TEXT (0,30)
        [JsonProperty(PropertyName = "latitude")]
        public string latitude { get; set; }
        // TEXT (0,30)
        [JsonProperty(PropertyName = "longitude")]
        public string longitude { get; set; }
    }
}
