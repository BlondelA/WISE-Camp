using Metier.Data;
using Metier.Entities;
using Metier.Repositories;
using Metier.Repositories.Utilisateur;
using Metier.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly BaseDbContext _baseDbContext;

        public UtilisateurService(IUtilisateurRepository utilisateurRepository, BaseDbContext baseDbContext)
        {
            _utilisateurRepository = utilisateurRepository;
            _baseDbContext = baseDbContext;
        }

        public Utilisateur AddUtilisateur(Utilisateur utilisateur)
        {
            if (utilisateur != null)
            {
                var role = new Role()
                {
                    id = 1,
                    libelle = "Administrateur"
                };
                utilisateur.role = role;
                var utilisateutInDb = _utilisateurRepository.Add(utilisateur);
                _baseDbContext.Commit();
                return utilisateutInDb;
            }
            return null;
        }

    }
}
