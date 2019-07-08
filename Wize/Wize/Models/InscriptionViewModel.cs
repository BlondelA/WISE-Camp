using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wize.Models
{
    public class InscriptionViewModel
    {
        // TEXT 
        public string nom { get; set; }
        // TEXT
        public string prenom { get; set; }
        // TEXT
        public string mail { get; set; }
        // TEXT
        public string motDePasse { get; set; }
        // TEXT
        public string confirmationMotDePasse { get; set; }
        // Role
        //public RoleViewModel role { get; set; }

        public Utilisateur InscriptionViewModelToUtilisateur()
        {
            var utilisateur = new Utilisateur();
            utilisateur.nom = this.nom;
            utilisateur.prenom = this.prenom;
            utilisateur.mail = this.mail;
            utilisateur.motDePasse = this.motDePasse;
            return utilisateur;
        }
    }
}
