using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Adresse
{
    public interface IAdresseRepository
    {
        Maybe<Metier.Entities.Adresse> Get(int id);
        Metier.Entities.Adresse Add(Metier.Entities.Adresse entity);
    }
}
