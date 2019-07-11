using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.OrganismeFormationResponsable
{
    public class OrganismeFormationResponsableRepository : IOrganismeFormationResponsableRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.OrganismeFormationResponsable> _dbSet;

        public OrganismeFormationResponsableRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.OrganismeFormationResponsables;
        }

        public virtual Maybe<Metier.Entities.OrganismeFormationResponsable> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.OrganismeFormationResponsable Add(Metier.Entities.OrganismeFormationResponsable entity)
        {
            var organismeFormationResponsable = _baseDbContext.OrganismeFormationResponsables.Add(entity).Entity;
            return organismeFormationResponsable;
        }
    }
}
