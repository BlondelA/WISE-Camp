using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.OrganismeFormateur
{
    public interface IOrganismeFormateurRepository
    {
        Maybe<Metier.Entities.OrganismeFormateur> Get(int id);
        Metier.Entities.OrganismeFormateur Add(Metier.Entities.OrganismeFormateur entity);
    }
}
