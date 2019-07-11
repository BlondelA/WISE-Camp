using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Action
{
    public interface IActionRepository
    {
        Maybe<Metier.Entities.Action> Get(int id);
        Metier.Entities.Action Add(Metier.Entities.Action entity);
    }
}
