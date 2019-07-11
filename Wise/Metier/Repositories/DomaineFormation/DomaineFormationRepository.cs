using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.DomaineFormation
{
    public class DomaineFormationRepository : IDomaineFormationRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.DomaineFormation> _dbSet;

        public DomaineFormationRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.DomaineFormations;
        }

        public virtual Maybe<Metier.Entities.DomaineFormation> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.DomaineFormation Add(Metier.Entities.DomaineFormation entity)
        {
            var domaineFormation = _baseDbContext.DomaineFormations.Add(entity).Entity;
            return domaineFormation;
        }
    }
}
