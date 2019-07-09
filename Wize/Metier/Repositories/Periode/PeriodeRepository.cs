using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Periode
{
    public class PeriodeRepository : IPeriodeRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Periode> _dbSet;

        public PeriodeRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Periodes;
        }

        public virtual Maybe<Metier.Entities.Periode> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Periode Add(Metier.Entities.Periode entity)
        {
            var periode = _baseDbContext.Periodes.Add(entity).Entity;
            return periode;
        }
    }
}
