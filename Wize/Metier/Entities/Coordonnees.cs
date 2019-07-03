namespace Metier.Entities
{
    public class Coordonnees
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
        public Adresse adresse { get; set; }
        public Numtel telfix { get; set; }
        public Numtel portable { get; set; }
        public Numtel fax { get; set; }
        public Web web { get; set; }
    }
}
