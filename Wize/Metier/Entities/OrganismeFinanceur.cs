using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class OrganismeFinanceur
    {
        public int Id { get; set; }
        //CODE(dict-financeurs) non nul
        public int codeFinanceur { get; set; }
        //INT()
        public int nbPlaceFinancees { get; set; }
    }
}
