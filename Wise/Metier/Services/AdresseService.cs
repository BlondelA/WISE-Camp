using Metier.Data;
using Metier.Entities;
using Metier.Repositories;
using Metier.Repositories.Adresse;
using Metier.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Services
{
    public class AdresseService : IAdresseService
    {
        private readonly IAdresseRepository _adresseRepository;
        private readonly BaseDbContext _baseDbContext;

        public AdresseService(IAdresseRepository adresseRepository, BaseDbContext baseDbContext)
        {
            _adresseRepository = adresseRepository;
            _baseDbContext = baseDbContext;
        }

        public Adresse AddAdresse(Adresse adresse)
        {
            if (adresse != null)
            {
                var adresseInDb = _adresseRepository.Add(adresse);
                _baseDbContext.Commit();
                return adresseInDb;
            }
            return null;
        }

    }
}
