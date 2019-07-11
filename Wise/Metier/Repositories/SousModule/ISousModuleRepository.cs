using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.SousModule
{
    public interface ISousModuleRepository
    {
        Maybe<Metier.Entities.SousModule> Get(int id);
        Metier.Entities.SousModule Add(Metier.Entities.SousModule entity);
    }
}
