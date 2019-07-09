using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.NumTel
{
    public interface INumtelRepository
    {
        Maybe<Metier.Entities.Numtel> Get(int id);
        Metier.Entities.Numtel Add(Metier.Entities.Numtel entity);
    }
}
