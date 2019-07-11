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
    public class AdresseController : Controller
    {
        private readonly IAdresseService _adresseService;
        
        public AdresseController(IAdresseService adresseService)
        {
            _adresseService = adresseService;
        }
        
        //page de base
        [HttpGet]
        public ActionResult Adresse()
        {
            return View();
        }

        //ajout d'une adresse dans la base
        [HttpPost]
        public ActionResult Adresse(AdresseViewModel adresseViewModel)
        {
            if(ModelState.IsValid)
            {
                if(adresseViewModel != null)
                {
                    var adresse = adresseViewModel.AdresseViewModelToAdresse();

                    _adresseService.AddAdresse(adresse);
                }
            }            
            return RedirectToAction("Index","Home");
        }

        //suppression d'une adresse dans la base
        [HttpPost]
        public ActionResult DeleteAdresse()
        {
            return View();
        }

        //mise a jour d'une adresse
        [HttpPost]
        public ActionResult UpdateAdresse()
        {
            return View();
        }


    }
}
