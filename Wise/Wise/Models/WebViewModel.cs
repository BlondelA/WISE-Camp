using Newtonsoft.Json;

namespace Wise.Models
{
    public class WebViewModel
    {
        // TEXT (3, 400)
        [JsonProperty(PropertyName = "urlweb")]
        public string urlweb { get; set; }
    }
}
