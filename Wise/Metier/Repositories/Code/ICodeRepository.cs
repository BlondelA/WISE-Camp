using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Code
{
    public interface ICodeRepository
    {
        Maybe<Metier.Entities.Code> Get(int id);
        Metier.Entities.Code Add(Metier.Entities.Code entity);
    }
}
