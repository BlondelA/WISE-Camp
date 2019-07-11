using CSharpFunctionalExtensions;
using Metier.Data;
using Metier.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Metier.Repositories.Utilisateur;

namespace Metier.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private readonly BaseDbContext  _baseDbContext;
        
        private readonly IQueryable<Metier.Entities.Utilisateur> _dbSet;

        public UtilisateurRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
            _dbSet = baseDbContext.Utilisateurs;
        }

        public virtual Maybe<Metier.Entities.Utilisateur> Get(int id) => _dbSet.FirstOrDefault(u => u.Id == id);

        public Maybe<Metier.Entities.Utilisateur> GetByEmail(string email)
        {
            var user = _dbSet
                .FirstOrDefault(u => u.mail == email);
            return user;
        }

        public Metier.Entities.Utilisateur Add(Metier.Entities.Utilisateur entity)
        {
            var utilisateur = _baseDbContext.Utilisateurs.Add(entity).Entity;
            return utilisateur;
        }

        public Maybe<Metier.Entities.Utilisateur> getEmailAndPassword(string email, string motDePasse)
        {
            var utilisateur = _dbSet
                .FirstOrDefault(u => u.mail == email && u.motDePasse == motDePasse);

            //var utilisateur = _baseDbContext.Utilisateurs
            //    .Where(u => u.mail == u.mail && u.motDePasse == u.motDePasse).FirstOrDefault();
            return utilisateur;
        }
    }
}
