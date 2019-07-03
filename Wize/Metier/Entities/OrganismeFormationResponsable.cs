using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class OrganismeFormationResponsable : Organisme
    {
        // TEXT (11,11) non null
        public string numeroActivite { get; set; }
        // TEXT (11,250) non null
        public string nomOrganisme { get; set; }
        // Cooredonnées
        public Coordonnees coordonnees { get; set;}
        // TEXT (0,3000) 
        public string renseignementsSpecifiques { get; set; }
        // TEXT
        public string agreementDatadock { get; set; }
    }
}
