using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class Formation
    {
        //DomaineFormation
        public DomaineFormation domaineFormation {get; set;}
        //TEXT(1,255) non nul
        public string intituleFormation {get; set;}
    }
}

