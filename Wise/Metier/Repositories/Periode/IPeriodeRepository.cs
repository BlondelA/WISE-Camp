using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Periode
{
    public interface IPeriodeRepository
    {
        Maybe<Metier.Entities.Periode> Get(int id);
        Metier.Entities.Periode Add(Metier.Entities.Periode entity);
    }
}
