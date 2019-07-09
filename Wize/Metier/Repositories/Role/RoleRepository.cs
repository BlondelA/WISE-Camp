using System.Linq;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Role
{
    public class RoleRepository : IRoleRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Role> _dbSet;

        public RoleRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Roles;
        }

        public virtual Maybe<Metier.Entities.Role> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Role Add(Metier.Entities.Role entity)
        {
            var role = _baseDbContext.Roles.Add(entity).Entity;
            return role;
        }
    }
}
