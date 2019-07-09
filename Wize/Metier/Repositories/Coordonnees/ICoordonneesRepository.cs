using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Coordonnees
{
    public interface ICoordonneesRepository
    {
        Maybe<Metier.Entities.Coordonnees> Get(int id);
        Metier.Entities.Coordonnees Add(Metier.Entities.Coordonnees entity);
    }
}
