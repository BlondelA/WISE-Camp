using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metier.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wize.Models;

namespace Wize.Controllers
{
    public class FormationController : Controller
    {
        //private readonly IFormationService _formationService;

        //public FormationController(IFormationService formationService)
        //{
        //    _formationService = formationService;
        //}

        //CREATION
        // GET: Formation
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

        // GET: Formation/Create
        public ActionResult Create()
        {
            return View("CreationFormation");
        }

        // POST: Formation/Create
        [HttpPost]
        public ActionResult Create(FormationViewModel formationViewModel)
        {
            if (ModelState.IsValid)
            {
                var formation = formationViewModel.formationViewModelToFormation();
                //_formationService.AddFormation(formation);
                return RedirectToAction("Index", "Home");
            }
            return View(formationViewModel);
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

                return RedirectToAction("Edit", "Formation");
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

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }
    }
}