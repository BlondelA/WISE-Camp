using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Geolocalisation
{
    public class GeolocalisationRepository : IGeolocalisationRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Geolocalisation> _dbSet;

        public GeolocalisationRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Geolocalisations;
        }

        public virtual Maybe<Metier.Entities.Geolocalisation> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Geolocalisation Add(Metier.Entities.Geolocalisation entity)
        {
            var geolocalisation = _baseDbContext.Geolocalisations.Add(entity).Entity;
            return geolocalisation;
        }
    }
}
