using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metier.Entities;
using Metier.Services;
using Metier.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Wize.Models;
using Microsoft.AspNetCore.Http;


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
                    //FormsAuthentication.SetAuthCookie(utilisateur.Id.ToString(), false);


                }
                return RedirectToAction("Index", "Home");
            }
            return View(inscriptionViewModel);

        }

        [HttpGet]
        public ActionResult Connexion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Connexion(ConnexionViewModel connexionViewModel)
        {
            if (ModelState.IsValid)
            {
                var userOrNothing = _utilisateurService.getEmailAndPassword(connexionViewModel.mail, connexionViewModel.motDePasse);
                if (userOrNothing == null)
                {
                    ModelState.AddModelError(nameof(ConnexionViewModel.mail),
                        $"L'email ne correspond à aucun compte utilisateur existant");
                    return View(connexionViewModel);
                }
                HttpContext.Session.SetString("UserID", userOrNothing.Id.ToString());
                HttpContext.Session.SetString("Usernom", userOrNothing.nom);
                HttpContext.Session.SetString("Userprenom", userOrNothing.prenom);
                HttpContext.Session.SetString("Useremail", userOrNothing.mail);

                return RedirectToAction("AccueilConnecte");


            }
            return View(connexionViewModel);

        }


        public ActionResult AccueilConnecte()
        {

            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.Usernom = HttpContext.Session.GetString("Usernom");
                ViewBag.Userprenom = HttpContext.Session.GetString("Userprenom");
                ViewBag.Useremail = HttpContext.Session.GetString("Useremail");

                return View("AccueilConnecte");
            }

            return RedirectToAction("Connexion");
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
