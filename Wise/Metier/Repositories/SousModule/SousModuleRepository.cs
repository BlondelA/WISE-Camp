using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.SousModule
{
    public class SousModuleRepository : ISousModuleRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.SousModule> _dbSet;

        public SousModuleRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.SousModules;
        }

        public virtual Maybe<Metier.Entities.SousModule> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.SousModule Add(Metier.Entities.SousModule entity)
        {
            var sousModule = _baseDbContext.SousModules.Add(entity).Entity;
            return sousModule;
        }
    }
}
