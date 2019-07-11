using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class OrganismeFormateur
    {
        public int Id { get; set; }
        // TEXT (14,14) non null
        public string siret { get; set; }
        // TEXT (1,250) non null
        public string raisonSociale { get; set; }
        public Coordonnees contactOrganisme { get; set; }
        public Potentiel potentiel { get; set; }
    }
}
