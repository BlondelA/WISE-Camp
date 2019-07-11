using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wise.Models
{
    public class ConnexionViewModel
    {
        // TEXT
        [Display(Prompt = "Email")]
        [EmailAddress(ErrorMessage = "Email invalide")]
        [Required(ErrorMessage = "L'email est obligatoire")]
        public string mail { get; set; }
        // TEXT
        [Display(Prompt = "Mot de passe")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Mot de passe obligatoire")]
        public string motDePasse { get; set; }
    }
}
