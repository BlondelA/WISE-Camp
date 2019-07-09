using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Role
{
    public interface IRoleRepository
    {
        Maybe<Metier.Entities.Role> Get(int id);
        Metier.Entities.Role Add(Metier.Entities.Role entity);
    }
}
