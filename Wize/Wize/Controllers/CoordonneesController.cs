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
    public class CoordonneesController : Controller
    {
        private readonly ICoordonneesService _coordonneesService;


        public CoordonneesController(IUtilisateurService utilisateurService)
        {
            _coordonneesService = _coordonneesService;
        }
        
        [HttpGet]
        public ActionResult AjoutCoordonnees()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AjoutCoordonnees(CoordonneesViewModel coordonneesViewModel)
        {
            if (ModelState.IsValid)
            {
                if (coordonneesViewModel != null)
                {
                    var coordonnees = coordonneesViewModel.CoordonneesViewModelToCoordonnees();
                }
            }
            return View();
        }
    }
}