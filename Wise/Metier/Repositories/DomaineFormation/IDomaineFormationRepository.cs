using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.DomaineFormation
{
    public interface IDomaineFormationRepository
    {
        Maybe<Metier.Entities.DomaineFormation> Get(int id);
        Metier.Entities.DomaineFormation Add(Metier.Entities.DomaineFormation entity);
    }
}
