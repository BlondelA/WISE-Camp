using Metier.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wise.Models;

namespace Wise.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUtilisateurService _utilisateurService;

        public LoginController(IUtilisateurService utilisateurService)
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
                return RedirectToAction("Connexion", "Login");
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
                        $"L'email ne correspond � aucun compte utilisateur existant");
                    return View(connexionViewModel);
                }
                HttpContext.Session.SetString("UserID", userOrNothing.Id.ToString());
                HttpContext.Session.SetString("Usernom", userOrNothing.nom);
                HttpContext.Session.SetString("Userprenom", userOrNothing.prenom);
                HttpContext.Session.SetString("Useremail", userOrNothing.mail);

                return RedirectToAction("AccueilConnecte","Utilisateur");
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

        [HttpGet]
        public ActionResult Recuperation()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Recuperation(string courriel)
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult NouveauMotDePasse()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult NouveauMotDePasse(string motDePasse, string motDePasseConfirmation)
        {
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Connexion", "Login");
        }


        public ActionResult LayoutLogin()
        {
            return View("_LayoutLogin");
        }
    }
}