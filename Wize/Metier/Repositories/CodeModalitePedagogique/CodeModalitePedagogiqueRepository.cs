using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.CodeModalitePedagogique
{
    public class CodeModalitePedagogiqueRepository : ICodeModalitePedagogiqueRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.CodeModalitePedagogique> _dbSet;

        public CodeModalitePedagogiqueRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.CodeModalitePedagogiques;
        }

        public virtual Maybe<Metier.Entities.CodeModalitePedagogique> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.CodeModalitePedagogique Add(Metier.Entities.CodeModalitePedagogique entity)
        {
            var codeModalitePedagogique = _baseDbContext.CodeModalitePedagogiques.Add(entity).Entity;
            return codeModalitePedagogique;
        }
    }
}
