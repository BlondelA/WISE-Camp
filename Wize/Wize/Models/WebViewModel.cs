using Newtonsoft.Json;

namespace Wize.Models
{
    public class WebViewModel
    {
        // TEXT (3, 400)
        [JsonProperty(PropertyName = "urlweb")]
        public string urlweb { get; set; }
    }
}
