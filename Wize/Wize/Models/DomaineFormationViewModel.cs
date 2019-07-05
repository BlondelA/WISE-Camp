using Newtonsoft.Json;

namespace Wize.Models
{
    public class DomaineFormationViewModel
    {
        // TEXT (5,5)
        [JsonProperty(PropertyName = "code-FORMACODE")]
        public string codeFORMACODE { get; set; }
        // TEXT (3,3)
        [JsonProperty(PropertyName = "code-NSF")]
        public string codeNSF { get; set; }
        // TEXT (5,5)
        [JsonProperty(PropertyName = "code-ROME")]
        public string codeROME { get; set; }
    }
}
