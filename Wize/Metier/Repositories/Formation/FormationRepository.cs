using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Formation
{
    public class FormationRepository : IFormationRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Formation> _dbSet;

        public FormationRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Formations;
        }

        public virtual Maybe<Metier.Entities.Formation> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Formation Add(Metier.Entities.Formation entity)
        {
            var formation = _baseDbContext.Formations.Add(entity).Entity;
            return formation;
        }
    }
}
