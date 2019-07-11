namespace Metier.Entities
{
    public class Formation
    {
        public int Id { get; set; }
        public DomaineFormation domaineFormation { get; set; }
        // TEXT(1,255) non nul
        public string intituleFormation { get; set; }
        // TEXT(1,3000) non nul
        public string objectifFormation { get; set; }
        // TEXT(1,3000) non nul
        public string resultatsAttendus { get; set; }
        // TEXT(1,3000) non nul
        public string contenuFormation { get; set; }
        // CODE(dict-boolean) non nul
        public bool certifiante { get; set; }
        // non nul
        public Coordonnees contactFormation { get; set; }
        // CODE(dict-type-parcours) non nul
        public Code parcoursDeFormation { get; set; }
        // CODE(dict-niveaux) non nul
        public Code codeNiveauEntree { get; set; }
        // CODE(dict-AIS)
        public Code objectifGeneralFormation { get; set; }
        public Certification certification { get; set; }
        public Web urlFormation { get; set; }
        public Action action { get; set; }
        public OrganismeFormationResponsable organismeFormationResponsable { get; set; }
        // CODE(dict-niveaux)
        public Code codeNiveauSortie { get; set; } 
        // TEXT(1,3000)
        public string identifiantModule { get; set; }
        // CODE(dict-type-positionnement)
        public Code positionnement { get; set; }
        public SousModule sousModule { get; set; }
        public ModulesPrerequis modulesPrerequis { get; set; }
        // INT
        public int creditsEcts { get; set; }
        // BOOL
        public bool eligibiliteCpf { get; set; }
        // TEXT
        public string validations { get; set; }
    }
}
