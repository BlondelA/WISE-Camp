﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class Adresse
    {
        // TEXT (1,50)
        public string ligne{get; set;}
        // TEXT (5,5)
        public string codepostal {get; set;}
        // TEXT (1,50)
        public string ville {get; set;}
        // TEXT (2,3)
        public string departement {get; set;}
        // TEXT (5,5)
        public string code_INSEE_commune{get; set;}
        // TEXT (4,5)
        public string code_INSEE_canton{get; set;}
        // TEXT (2,2)
        public string region {get; set;}
        // TEXT (2,2)
        public string pays {get; set;}
        // geolocalisation
        //public Geolocalisation geolocalisation { get; set; }
    }
}
