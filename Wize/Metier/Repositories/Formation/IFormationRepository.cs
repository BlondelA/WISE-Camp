using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Formation
{
    public interface IFormationRepository
    {
        Maybe<Metier.Entities.Formation> Get(int id);
        Metier.Entities.Formation Add(Metier.Entities.Formation entity);
    }
}
