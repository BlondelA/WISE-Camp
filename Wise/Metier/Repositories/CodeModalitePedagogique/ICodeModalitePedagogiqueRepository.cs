using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.CodeModalitePedagogique
{
    public interface ICodeModalitePedagogiqueRepository
    {
        Maybe<Metier.Entities.CodeModalitePedagogique> Get(int id);

        Metier.Entities.CodeModalitePedagogique Add(Metier.Entities.CodeModalitePedagogique entity);
    }
}
