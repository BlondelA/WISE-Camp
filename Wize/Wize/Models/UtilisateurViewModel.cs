using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wize.Models
{
    public class UtilisateurViewModel
    {
        // TEXT 
        public string nom { get; set; }
        // TEXT
        public string prenom { get; set; }
        // TEXT
        public string mail { get; set; }
        // TEXT
        public string motDePasse { get; set; }
        // Role
        public RoleViewModel role { get; set; }

    }
}
