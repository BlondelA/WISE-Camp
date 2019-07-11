using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.OrganismeFinanceur
{
    public interface IOrganismeFinanceurRepository
    {
        Maybe<Metier.Entities.OrganismeFinanceur> Get(int id);
        Metier.Entities.OrganismeFinanceur Add(Metier.Entities.OrganismeFinanceur entity);
    }
}
