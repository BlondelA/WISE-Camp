using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class Utilisateur
    {
        public int Id { get; set; }
        // TEXT 
        public string nom { get; set; }
        // TEXT
        public string prenom { get; set; }
        // TEXT
        public string mail { get; set; }
        // TEXT
        public string motDePasse { get; set; }
        public Role role { get; set; }
    }
}
