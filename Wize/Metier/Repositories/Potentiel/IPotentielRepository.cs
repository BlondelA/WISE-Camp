using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Potentiel
{
    public interface IPotentielRepository
    {
        Maybe<Metier.Entities.Potentiel> Get(int id);
        Metier.Entities.Potentiel Add(Metier.Entities.Potentiel entity);
    }
}
