using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Services.Interfaces
{
    public interface IUtilisateurService
    {
        Utilisateur AddUtilisateur(Utilisateur utilisateur);
        Utilisateur getEmailAndPassword(string email, string motDePasse);

    }
}
