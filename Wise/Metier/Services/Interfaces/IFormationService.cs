using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Services.Interfaces
{
    public interface IFormationService
    {
        List<Formation> GetAllFormations();
    }
}