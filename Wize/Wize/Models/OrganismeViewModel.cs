using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class Organisme
    {
        // TEXT (14,14) non null
        public string siret { get; set; }
        // TEXT (1,250) non null
        public string raisonSociale { get; set; }
        // Coordonnées
        public Coordonnees contactOrganisme { get; set; }
        // potentiel
        public Potentiel potentiel { get; set; }
    }
}
