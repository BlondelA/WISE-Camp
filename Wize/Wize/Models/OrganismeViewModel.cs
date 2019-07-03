namespace Wize.Models
{
    public class OrganismeViewModel
    {
        // TEXT (14,14) non null
        public string siret { get; set; }
        // TEXT (1,250) non null
        public string raisonSociale { get; set; }
        // Coordonnées
        public CoordonneesViewModel contactOrganisme { get; set; }
        // potentiel
        public PotentielViewModel potentiel { get; set; }
    }
}
