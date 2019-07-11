using Newtonsoft.Json;

namespace Wize.Models
{
    public class NumtelViewModel
    {
        //TEXT(1,25)
        [JsonProperty(PropertyName = "numtel")]
        public string numtel { get; set; }
    }
}
