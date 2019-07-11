using Metier.Data;
using Metier.Entities;
using Metier.Repositories;
using Metier.Repositories.Coordonnees;
using Metier.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Services
{
    public class CoordonneesService : ICoordonneesService
    {
        private readonly ICoordonneesRepository _coordonneesRepository;
        private readonly BaseDbContext _baseDbContext;

        public CoordonneesService(ICoordonneesRepository coordonneesRepository, BaseDbContext baseDbContext)
        {
            _coordonneesRepository = coordonneesRepository;
            _baseDbContext = baseDbContext;
        }

        public Coordonnees AddCoordonnees(Coordonnees coordonnees)
        {
            if (coordonnees != null)
            {
                var coordonneesInDb = _coordonneesRepository.Add(coordonnees);
                _baseDbContext.Commit();
                return coordonneesInDb;
            }
            return null;
        }
    }
}