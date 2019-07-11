using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.OrganismeFinanceur
{
    public class OrganismeFinanceurRepository : IOrganismeFinanceurRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.OrganismeFinanceur> _dbSet;

        public OrganismeFinanceurRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.OrganismeFinanceurs;
        }

        public virtual Maybe<Metier.Entities.OrganismeFinanceur> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.OrganismeFinanceur Add(Metier.Entities.OrganismeFinanceur entity)
        {
            var organismeFinanceur = _baseDbContext.OrganismeFinanceurs.Add(entity).Entity;
            return organismeFinanceur;
        }
    }
}
