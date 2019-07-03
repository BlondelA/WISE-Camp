using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class Formation
    {
        //DomaineFormation
        public DomaineFormation domaineFormation { get; set; }
        //TEXT(1,255) non nul
        public string intituleFormation { get; set; }
        //TEXT(1,3000) non nul
        public string objectifFormation { get; set; }
        //TEXT(1,3000) non nul
        public string resultatsAttendus { get; set; }
        //TEXT(1,3000) non nul
        public string contenuFormation { get; set; }
        //CODE(dict-boolean) non nul
        public bool certifiante { get; set; }
        //coordonnees non nul
        public Coordonnees contactFormation { get; set; }
        //CODE(dict-type-parcours) non nul
        //public int parcoursDeFormation { get; set; }
        //CODE(dict-niveaux) non nul
        public int codeNiveauEntree { get; set; }
        //CODE(dict-AIS)
        //public int objectifGeneralFormation { get; set; }
        //certification
        public Certification certification { get; set; }
        //web
        public Web urlFormation { get; set; }
        //action
        public Action action { get; set; }
        //organisme-formation-responsable
        public OrganismeFormationResponsable organismeFormationResponsable { get; set; }
        //CODE(dict-niveaux)
        //public int codeNiveauSortie { get; set; } 
        //TEXT(1,3000)
        public string identifiantModule { get; set; }
        //CODE(dict-type-positionnement)
        //public int positionnement { get; set; }
        //sous-module
        public SousModule sousModule { get; set; }
        //modules-prerequis
        public ModulePrerequis modulesPrerequis { get; set; }
        //INT
        public int creditsEcts { get; set; }
        //BOOL
        public bool eligibiliteCpf { get; set; }
        //TEXT
        public string validations { get; set; }
    }
}
