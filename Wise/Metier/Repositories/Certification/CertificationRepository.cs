using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Certification
{
    public class CertificationRepository : ICertificationRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Certification> _dbSet;

        public CertificationRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Certifications;
        }

        public virtual Maybe<Metier.Entities.Certification> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Certification Add(Metier.Entities.Certification entity)
        {
            var certification = _baseDbContext.Certifications.Add(entity).Entity;
            return certification;
        }
    }
}
