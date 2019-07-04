using Newtonsoft.Json;

namespace Wize.Models
{
    public class ModulesPrerequisViewModel
    {
        //TEXT(1,3000) non nul
        [JsonProperty(PropertyName = "reference-module")]
        public string referenceModule { get; set; }  
    }
}
