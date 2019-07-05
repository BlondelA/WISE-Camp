using Newtonsoft.Json;
using Wize.Models;

namespace Metier.Services.ImportExport
{
    class SerialiseJson
    {
        public FormationViewModel formationViewModel { get;set; }



        public string PopulateJson()
        {
            return JsonConvert.SerializeObject(formationViewModel);
        }
    }
}