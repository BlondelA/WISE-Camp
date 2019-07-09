using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Session
{
    public interface ISessionRepository
    {
        Maybe<Metier.Entities.Session> Get(int id);
        Metier.Entities.Session Add(Metier.Entities.Session entity);
    }
}
