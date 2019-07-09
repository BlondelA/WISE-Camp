using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Metier.Repositories;
using Metier.Data;
using CSharpFunctionalExtensions;


namespace Metier.Repositories.Adresse
{
    public class AdresseRepository : IAdresseRepository
    {
        private readonly BaseDbContext _baseDbContext;

        private readonly IQueryable<Metier.Entities.Adresse> _dbSet;

        public AdresseRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Adresses;
        }

        public virtual Maybe<Metier.Entities.Adresse> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Metier.Entities.Adresse Add(Metier.Entities.Adresse entity)
        {
            var adresse = _baseDbContext.Adresses.Add(entity).Entity;
            return adresse;
        }
    }
}
