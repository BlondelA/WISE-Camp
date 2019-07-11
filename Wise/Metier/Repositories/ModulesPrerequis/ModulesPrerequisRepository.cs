using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.ModulesPrerequis
{
    public class ModulesPrerequisRepository : IModulesPrerequisRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.ModulesPrerequis> _dbSet;

        public ModulesPrerequisRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.ModulesPrerequis;
        }

        public virtual Maybe<Metier.Entities.ModulesPrerequis> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.ModulesPrerequis Add(Metier.Entities.ModulesPrerequis entity)
        {
            var modulesPrerequis = _baseDbContext.ModulesPrerequis.Add(entity).Entity;
            return modulesPrerequis;
        }
    }
}
