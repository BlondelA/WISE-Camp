namespace Metier.Entities
{
    public class OrganismeFormationResponsable 
    {
        public int Id { get; set; }
        // TEXT (14,14) non null
        public string siret { get; set; }
        // TEXT (1,250) non null
        public string raisonSociale { get; set; }
        // Coordonnées
        public Coordonnees contactOrganisme { get; set; }
        // potentiel
        public Potentiel potentiel { get; set; }
        // TEXT (11,11) non null
        public string numeroActivite { get; set; }
        // TEXT (11,250) non null
        public string nomOrganisme { get; set; }
        // Cooredonnées
        public Coordonnees coordonnees { get; set;}
        // TEXT (0,3000) 
        public string renseignementsSpecifiques { get; set; }
        // TEXT
        public string agreementDatadock { get; set; }
    }
}
