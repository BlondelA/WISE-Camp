using Newtonsoft.Json;

namespace Wise.Models
{
    public class OrganismeFinanceurViewModel 
    {
        //CODE(dict-financeurs) non nul
        [JsonProperty(PropertyName = "code-financeur")]
        public CodeViewModel codeFinanceur { get; set; }
        //INT()
        [JsonProperty(PropertyName = "nb-places-financees")]
        public int nbPlacesFinancees { get; set; }
    }
}
