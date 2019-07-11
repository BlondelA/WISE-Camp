namespace Metier.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public Periode periode { get; set; }
        public Adresse adresseInscription { get; set; }
        public Periode periodeInscription { get; set; }
        // TEXT(1,255)
        public string modaliteInscription { get; set; }
        // CODE(dict-etat-recrutement)
        public Code etatRecrutement { get; set; }
    }
}
