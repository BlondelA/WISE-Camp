using Newtonsoft.Json;

namespace Wize.Models
{
    public class CertificationViewModel
    {
        //TEXT(1,6)
        [JsonProperty(PropertyName = "code-RNCP")]
        public string codeRNCP { get; set; }
        //TEXT(1,6)
        [JsonProperty(PropertyName = "code-CERTIFINFO")]
        public string codeCERTIFINFO { get; set; }
    }
}
