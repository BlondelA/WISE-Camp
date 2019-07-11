using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Code
{
    public class CodeRepository : ICodeRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Code> _dbSet;

        public CodeRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Codes;
        }

        public virtual Maybe<Metier.Entities.Code> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Code Add(Metier.Entities.Code entity)
        {
            var code = _baseDbContext.Codes.Add(entity).Entity;
            return code;
        }
    }
}
