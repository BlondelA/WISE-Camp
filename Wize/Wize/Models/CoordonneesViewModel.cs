namespace Wize.Models
{
    public class CoordonneesViewModel
    {
        // TEXT (0 , 50)
        public string civilite { get; set; } 
        // TEXT (0 , 50)
        public string nom { get; set; } 
        // TEXT (0 , 50)
        public string prenom { get; set; } 
        // TEXT (0 , 50)
        public string ligne1 { get; set; } 
        // TEXT (0 , 50)
        public string ligne2 { get; set; } 
        // TEXT (0 , 50)
        public string ligne3 { get; set; } 
        // TEXT (3 , 160)
        public string courriel { get; set; }         
        public AdresseViewModel adresse { get; set; }
        public NumtelViewModel telfix { get; set; }
        public NumtelViewModel portable { get; set; }
        public NumtelViewModel fax { get; set; }
        public WebViewModel web { get; set; }
    }
}
