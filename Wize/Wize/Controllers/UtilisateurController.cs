using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metier.Entities;
using Metier.Services;
using Metier.Services.Interfaces;
using Microsoft.AspNetCore.Http;
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

        //CREATION
        // GET: User
        public ActionResult IndexCreationUtilisateur()
        {

            var utilisateurViewModel = new UtilisateurViewModel()
            {
            };
            return View(utilisateurViewModel);
        }

        // Inscription

        // GET: User
        [HttpGet]
        public ActionResult Inscription()
        {
            return View();
        }

        // POST : user
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



        //AFFICHAGE

        // GET: User
        public ActionResult IndexUtilisateurList()
        {

            var utilisateurViewModel = new UtilisateurViewModel()
            {
            };
            return View(utilisateurViewModel);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        //MODIFICATION
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Modification", "Utilisateur");
            }
            catch
            {
                return View();
            }
        }

        //SUPPRESSION
        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // DELETE: User/Delete/5
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Suppression", "Utilisateur");
            }
            catch
            {
                return View();
            }
        }
    }
}
