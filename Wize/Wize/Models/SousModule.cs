using Newtonsoft.Json;

namespace Wize.Models
{
    public class SousModuleViewModel
    {
        // TEXT (0 , 3000)
        [JsonProperty(PropertyName = "reference-module")]
        public string referenceModule { get; set; } 
        // CODE (dict-type-module)
        [JsonProperty(PropertyName = "type-module")]
        public CodeViewModel typeModule { get; set; } 
    }
}
