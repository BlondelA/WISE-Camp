using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metier.Services;
using Metier.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Wise.Models;

namespace Wise.Controllers
{
    public class CoordonneesController : Controller
    {
        private readonly ICoordonneesService _coordonneesService;
        
        public CoordonneesController(ICoordonneesService coordonneesService)
        {
            _coordonneesService = coordonneesService;
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

                    _coordonneesService.AddCoordonnees(coordonnees);
                }
            }
            return RedirectToAction("Index","Home");
        }

//        [HttpGet]
//        public ActionResult GetCoordonnees(int id)
//        {
//            return View();
//        }
//
//        [HttpGet]
//        public ActionResult EditCoordonnees(int id)
//        {
//            return View();
//        }
//
//        [HttpPost]
//        public ActionResult EditCoordonnees(CoordonneesViewModel coordonneesViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                if (coordonneesViewModel != null)
//                {
//                    
//                }
//            }
//            return View();
//        }
//
//        [HttpGet]
//        public ActionResult SupprimerCoordonnees()
//        {
//            return View();
//        }
    }
}