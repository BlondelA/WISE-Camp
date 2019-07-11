using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Web
{
    public class WebRepository : IWebRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Web> _dbSet;

        public WebRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Webs;
        }

        public virtual Maybe<Metier.Entities.Web> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Web Add(Metier.Entities.Web entity)
        {
            var web = _baseDbContext.Webs.Add(entity).Entity;
            return web;
        }
    }
}
