using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.Geolocalisation
{
    public interface IGeolocalisationRepository
    {
        Maybe<Metier.Entities.Geolocalisation> Get(int id);
        Metier.Entities.Geolocalisation Add(Metier.Entities.Geolocalisation entity);
    }
}
