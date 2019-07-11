using Metier.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wize.Models
{
    public class InscriptionViewModel
    {
        // TEXT 
        [Display(Prompt = "Nom")]
        [Required(ErrorMessage = "Un nom est obligatoire")]
        public string nom { get; set; }
        // TEXT
        [Display(Prompt = "Prenom")]
        [Required(ErrorMessage = "Un prénom est obligatoire")]
        public string prenom { get; set; }
        // TEXT
        [Display(Prompt = "Email")]
        [EmailAddress(ErrorMessage = "adresse incorrecte")]
        [Required(ErrorMessage = "L'email est obligatoire")]
        public string mail { get; set; }
        // TEXT
        [Display(Prompt = "Mot de passe")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
    //    [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$",
    //ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères respectant au moins 3 des 4 critères suivants : une majuscule (A - Z), une minuscule (a - z), un nombre (0 - 9) et un caractère spécial ( ex : !@#$%^&*)")]
        public string motDePasse { get; set; }
        // TEXT
        [Display(Prompt = "Confirmer votre mot de passe")]
        [DataType(DataType.Password)]
        [Compare("motDePasse", ErrorMessage = "Les mots de passe doivent être similaires")]
        [Required(ErrorMessage = "La confirmation du mot de passe est obligatoire")]
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
