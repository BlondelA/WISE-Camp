using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wize.Models;

namespace Wize.Controllers
{

    public class UtilisateurController : Controller
    {
        //CREATION
        // GET: User
        public ActionResult IndexCreationUtilisateur()
        {

            var utilisateurViewModel = new UtilisateurViewModel()
            {
            };
            return View(utilisateurViewModel);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Creation", "Utilisateur");
            }
            catch
            {
                return View();
            }
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