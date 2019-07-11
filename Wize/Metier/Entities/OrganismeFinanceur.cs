namespace Metier.Entities
{
    public class OrganismeFinanceur
    {
        public int Id { get; set; }
        // CODE(dict-financeurs) non nul
        public Code codeFinanceur { get; set; }
        // INT
        public int nbPlaceFinancees { get; set; }
    }
}
