using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Session
{
    public class SessionRepository : ISessionRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Session> _dbSet;

        public SessionRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Sessions;
        }

        public virtual Maybe<Metier.Entities.Session> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Session Add(Metier.Entities.Session entity)
        {
            var session = _baseDbContext.Sessions.Add(entity).Entity;
            return session;
        }
    }
}
