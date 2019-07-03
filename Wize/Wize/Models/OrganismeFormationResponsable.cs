namespace Wize.Models
{
    public class OrganismeFormationResponsableViewModel : OrganismeViewModel
    {
        // TEXT (11,11) non null
        public string numeroActivite { get; set; }
        // TEXT (11,250) non null
        public string nomOrganisme { get; set; }
        // Cooredonnées
        public CoordonneesViewModel coordonnees { get; set;}
        // TEXT (0,3000) 
        public string renseignementsSpecifiques { get; set; }
        // TEXT
        public string agreementDatadock { get; set; }
    }
}
