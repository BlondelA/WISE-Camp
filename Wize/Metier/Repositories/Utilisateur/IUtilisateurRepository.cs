using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;
using Metier.Entities;

namespace Metier.Repositories.Utilisateur
{
    public interface IUtilisateurRepository
    {
        Maybe<Metier.Entities.Utilisateur> Get(int id);

        Maybe<Metier.Entities.Utilisateur> GetByEmail(string email);

        Maybe<Metier.Entities.Utilisateur> getEmailAndPassword(string email, string motDePasse);

        
        Metier.Entities.Utilisateur Add(Metier.Entities.Utilisateur entity);
    }
}
