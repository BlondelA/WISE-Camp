using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text;
using Wize.Models;

namespace Wize.Controllers
{
    public class FormationController : Controller
    {
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