using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class Session
    {
        // periode 
        public Periode periode {get; set;}
        // adresse
        public Adresse adresseInscription {get; set;}
        // periode
        public Periode periodeInscription {get; set;}
        // TEXT(1,255)
        public string modaliteInscription {get; set;}
        // CODE(dict-etat-recrutement)
        //public etat-recrutement etat_recrutement { get; set; }
    }
}
