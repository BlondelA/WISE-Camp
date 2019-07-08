using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metier.Services;
using Metier.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Wize.Models;

namespace Wize.Controllers
{
    public class UtilisateurController : Controller
    {
        private readonly IUtilisateurService _utilisateurService;


        public UtilisateurController(IUtilisateurService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }


        [HttpGet]
        public ActionResult Inscription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inscription(InscriptionViewModel inscriptionViewModel)
        {
            if (ModelState.IsValid)
            {
                if (inscriptionViewModel != null && inscriptionViewModel.motDePasse == inscriptionViewModel.confirmationMotDePasse)
                {
                    var utilisateur = inscriptionViewModel.InscriptionViewModelToUtilisateur();

                    _utilisateurService.AddUtilisateur(utilisateur);
                }
                return RedirectToAction("Index","Home");
            }
            return View(inscriptionViewModel);

        }
    }
}
