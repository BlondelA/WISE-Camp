using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using Wize.Models;

namespace Metier.Services.ImportExport
{
    class SerialiseJson
    {
        public FormationViewModel formationViewModel { get;set; }

        public void OpenFile()
        {
            string path = Path.GetTempFileName();

            //string path = @"c:\temp\MyTest.txt";

            if (!File.Exists(path)) 
            {
                // Create the file.
                using (FileStream fs = File.Create(path)) 
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }

            // Open the stream and read it back.
            using (FileStream fs = File.OpenRead(path)) 
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
