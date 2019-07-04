using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public class ModulesPrerequis
    {
        public int Id { get; set; }
        //TEXT(1,3000) non nul
        public string referenceModule { get; set; } 
        
    }
}
