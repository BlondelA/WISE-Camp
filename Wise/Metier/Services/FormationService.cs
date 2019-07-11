using Metier.Data;
using Metier.Entities;
using Metier.Repositories;
using Metier.Repositories.Formation;
using Metier.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Services
{
    public class FormationService : IFormationService
    {
        private readonly IFormationRepository _formationRepository;
        private readonly BaseDbContext _baseDbContext;

        public FormationService(IFormationRepository formationRepository, BaseDbContext baseDbContext)
        {
            _formationRepository = formationRepository;
            _baseDbContext = baseDbContext;
        }

        public List<Formation> GetAllFormations()
        {
            var listFormation = _formationRepository.GetAll();
            if (listFormation != null)
            {
                return listFormation;
            }
            return null;
        }

    }
}
