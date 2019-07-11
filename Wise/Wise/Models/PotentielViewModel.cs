using Newtonsoft.Json;

namespace Wise.Models
{
    public class PotentielViewModel
    {
        // TEXT (5,5)
        [JsonProperty(PropertyName = "code-FORMACODE")]
        public string codeFORMACODE { get; set; }
    }
}
