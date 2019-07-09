using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Metier.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace Wize.Models
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
            coordonnees.civilite = this.civilite;
            coordonnees.nom = this.nom;
            coordonnees.prenom = this.prenom;
            coordonnees.ligne1 = this.ligne1;
            coordonnees.ligne2 = this.ligne2;
            coordonnees.ligne3 = this.ligne3;
            coordonnees.courriel = this.courriel;
            coordonnees.adresse = this.adresse;
            coordonnees.telfix.numtel = this.telfix.numtel;
            coordonnees.portable.numtel = this.portable.numtel;
            coordonnees.fax.numtel = this.fax.numtel;
            coordonnees.web.urlWeb = this.web.urlweb;
            return coordonnees;
        }
    }
    
    
}
