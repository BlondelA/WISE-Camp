using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Coordonnees
{
    public class CoordonneesRepository : ICoordonneesRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Coordonnees> _dbSet;

        public CoordonneesRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Coordonnees;
        }

        public virtual Maybe<Metier.Entities.Coordonnees> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Coordonnees Add(Metier.Entities.Coordonnees entity)
        {
            var coordonnees = _baseDbContext.Coordonnees.Add(entity).Entity;
            return coordonnees;
        }
    }
}
