using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Web
{
    public interface IWebRepository
    {
        Maybe<Metier.Entities.Web> Get(int id);
        Metier.Entities.Web Add(Metier.Entities.Web entity);
    }
}
