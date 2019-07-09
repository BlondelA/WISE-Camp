using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.OrganismeFormationResponsable
{
    public interface IOrganismeFormationResponsableRepository
    {
        Maybe<Metier.Entities.OrganismeFormationResponsable> Get(int id);
        Metier.Entities.OrganismeFormationResponsable Add(Metier.Entities.OrganismeFormationResponsable entity);
    }
}
