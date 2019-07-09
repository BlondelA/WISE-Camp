using Microsoft.AspNetCore.Mvc;

namespace Wize.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Inscription()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Inscription(string nom, string prenom, string mail, string mdp, string mdpConfirmation, string informationsComplementaires)
        {
            return RedirectToAction("Connexion", "Login");
        }

        [HttpGet]
        public ActionResult Connexion()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Connexion(string courriel, string motDePasse)
        {
            return View();
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

        public ActionResult LayoutLogin()
        {
            return View("_LayoutLogin");
        }
    }
}