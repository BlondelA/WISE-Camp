using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.NumTel
{
    public class NumtelRepository : INumtelRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Numtel> _dbSet;

        public NumtelRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Numtels;
        }

        public virtual Maybe<Metier.Entities.Numtel> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Numtel Add(Metier.Entities.Numtel entity)
        {
            var numtel = _baseDbContext.Numtels.Add(entity).Entity;
            return numtel;
        }
    }
}
