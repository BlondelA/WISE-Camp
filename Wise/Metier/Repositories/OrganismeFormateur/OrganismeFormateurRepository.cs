using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;


namespace Metier.Repositories.OrganismeFormateur
{
    public class OrganismeFormateurRepository : IOrganismeFormateurRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.OrganismeFormateur> _dbSet;

        public OrganismeFormateurRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.OrganismeFormateurs;
        }

        public virtual Maybe<Metier.Entities.OrganismeFormateur> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.OrganismeFormateur Add(Metier.Entities.OrganismeFormateur entity)
        {
            var organismeFormateur = _baseDbContext.OrganismeFormateurs.Add(entity).Entity;
            return organismeFormateur;
        }
    }
}
