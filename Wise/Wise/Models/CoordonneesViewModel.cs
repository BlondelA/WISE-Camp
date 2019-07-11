using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Metier.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace Wise.Models
{
    public class CoordonneesViewModel
    {
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "civilite")]
        public string civilite { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "nom")]
        public string nom { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "prenom")]
        public string prenom { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "ligne1")]
        public string ligne1 { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "ligne2")]
        public string ligne2 { get; set; } 
        // TEXT (0 , 50)
        [JsonProperty(PropertyName = "ligne3")]
        public string ligne3 { get; set; } 
        // TEXT (3 , 160)
        [JsonProperty(PropertyName = "courriel")]
        public string courriel { get; set; } 
        [JsonProperty(PropertyName = "adresse")]        
        public Adresse adresse { get; set; }
        [JsonProperty(PropertyName = "telfix")]
        public NumtelViewModel telfix { get; set; }
        [JsonProperty(PropertyName = "portable")]
        public NumtelViewModel portable { get; set; }
        [JsonProperty(PropertyName = "fax")]
        public NumtelViewModel fax { get; set; }
        [JsonProperty(PropertyName = "web")]
        public WebViewModel web { get; set; }
        
        public Coordonnees CoordonneesViewModelToCoordonnees()
        {
            var coordonnees = new Coordonnees();
            var numTel = new Numtel()
            {
                numtel = this.telfix.numtel
            };
            var portable = new Numtel()
            {
                numtel = this.portable.numtel
            };
            var fax = new Numtel()
            {
                numtel = this.fax.numtel
            };
            var web = new Web()
            {
                urlWeb = this.web.urlweb
            };
            coordonnees.civilite = this.civilite;
            coordonnees.nom = this.nom;
            coordonnees.prenom = this.prenom;
            coordonnees.ligne1 = this.ligne1;
            coordonnees.ligne2 = this.ligne2;
            coordonnees.ligne3 = this.ligne3;
            coordonnees.courriel = this.courriel;
            coordonnees.adresse = this.adresse;
            coordonnees.telfix = numTel;
            coordonnees.portable = portable;
            coordonnees.fax = fax;
            coordonnees.web = web;
            return coordonnees;
        }
    }
}
