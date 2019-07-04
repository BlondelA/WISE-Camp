using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class Periode
    {
        public int Id { get; set; }
        // DATE non-null
        public DateTime debut { get; set; }
        // DATE non-null
        public DateTime fin { get; set; }
    }
}
