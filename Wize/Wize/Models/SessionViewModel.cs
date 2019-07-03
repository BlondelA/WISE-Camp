using System;
using System.Collections.Generic;
using System.Text;

namespace Wize.Models
{
    public class SessionViewModel
    {
        // periode 
        public PeriodeViewModel periode { get; set; }
        // adresse
        public AdresseViewModel adresseInscription { get; set; }
        // periode
        public PeriodeViewModel periodeInscription { get; set; }
        // TEXT(1,255)
        public string modaliteInscription { get; set; }
        // CODE(dict-etat-recrutement)
        public CodeViewModel etatRecrutement { get; set; }
    }
}
