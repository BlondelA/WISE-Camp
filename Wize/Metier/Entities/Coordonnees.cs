namespace Metier.Entities
{
    public class Coordonnees
    {
        public string civilite; // TEXT (0 , 50)
        public string nom; // TEXT (0 , 50)
        public string prenom; // TEXT (0 , 50)
        public string ligne1; // TEXT (0 , 50)
        public string ligne2; // TEXT (0 , 50)
        public string ligne3; // TEXT (0 , 50)
        public string courriel; // TEXT (3 , 160)
        public Adresse adresse;
        public Numtel telfix;
        public Numtel portable;
        public Numtel fax;
        public WEB web;
    }
}