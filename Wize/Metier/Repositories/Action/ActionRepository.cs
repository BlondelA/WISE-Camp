using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Metier.Repositories;
using Metier.Data;
using CSharpFunctionalExtensions;

namespace Metier.Repositories.Action
{
    public class ActionRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Action> _dbSet;

        public ActionRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Actions;
        }

        public virtual Maybe<Metier.Entities.Action> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Action Add(Metier.Entities.Action entity)
        {
            var action = _baseDbContext.Actions.Add(entity).Entity;
            return action;
        }
    }
}
