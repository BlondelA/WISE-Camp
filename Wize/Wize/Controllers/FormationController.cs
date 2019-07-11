using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wize.Models;
using Metier.Services.Interfaces;


namespace Wize.Controllers
{
    public class FormationController : Controller
    {
        //CREATION
        // GET: User

        private readonly IFormationService _formationService;

        public FormationController(IFormationService formationService){
            _formationService = formationService;
        }
        public ActionResult IndexCreationFormation()
        {

            var formationViewModel = new FormationViewModel()
            {
            };
            return View(formationViewModel);
        }

        // GET: Formation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //GET:Formation/Qualifiante

        public ActionResult Qualifiante()
        {
            var formationViewModelQualifiantes =  new List<FormationViewModel>();
            var myFormationViewModelQualifiantes = formationViewModelQualifiantes.Where(x => x.certifiante == false);
            return View(myFormationViewModelQualifiantes);
        }

        //GET:Formation/Qualifiante

        public ActionResult Certifiante()
        {
            var formationViewModelCertifiantes =  new List<FormationViewModel>();
            var myFormationViewModelCertifiantes = formationViewModelCertifiantes.Where(x => x.certifiante == true);
            return View(myFormationViewModelCertifiantes);
        }

        //GET : Formation/DateBetween

        public ActionResult DateBetween(DateTime beginDate, DateTime endDate)
        {
            // on recupere les formations en base (getall)
            var allFormation = _formationService.GetAllFormations();
            
            var listFormations = new List<FormationViewModel>();
            foreach(var formation in allFormation){
                foreach(var session in formation.action.session){
                    if(session.periode.debut >= beginDate || session.periode.fin <= endDate){
                        var formationViewModel = new FormationViewModel();
                        listFormations.Add(formationViewModel.ViewModelForFilter(formation));
                    }
                }
            }

            // retourner la vue ou bien seulement les données en json en fonction de l'action faite
            return View(listFormations);
        }


        // GET: Formation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Create", "Formation");
            }
            catch
            {
                return View();
            }
        }

        // GET: Formation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Formation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Eddit", "Formation");
            }
            catch
            {
                return View();
            }
        }

        // GET: Formation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Formation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Delete", "Formation");
            }
            catch
            {
                return View();
            }
        }

        public FormationViewModel formationViewModel { get; set; }

        public void OpenFile()
        {
            string path = Path.GetTempFileName();

            //string path = @"c:\temp\MyTest.txt";

            if (!System.IO.File.Exists(path)) 
            {
                // Create the file.
                using (FileStream fs = System.IO.File.Create(path)) 
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }

            // Open the stream and read it back.
            using (FileStream fs = System.IO.File.OpenRead(path)) 
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b,0,b.Length) > 0) 
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }

         public string PopulateJson()
        {
            return JsonConvert.SerializeObject(formationViewModel);
        }
    }
}