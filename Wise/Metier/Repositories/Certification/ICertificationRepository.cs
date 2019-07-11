using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Certification
{
    public interface ICertificationRepository
    {
        Maybe<Metier.Entities.Certification> Get(int id);
        Metier.Entities.Certification Add(Metier.Entities.Certification entity);
    }
}
