using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Potentiel
{
    public class PotentielRepository : IPotentielRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Potentiel> _dbSet;

        public PotentielRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Potentiels;
        }

        public virtual Maybe<Metier.Entities.Potentiel> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Potentiel Add(Metier.Entities.Potentiel entity)
        {
            var potentiel = _baseDbContext.Potentiels.Add(entity).Entity;
            return potentiel;
        }
    }
}
