using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using Wize.Models;

namespace Metier.Services.ImportExport
{
    class SerialiseJson
    {

        public FormationViewModel formationViewModel { get;set; } = new FormationViewModel();

        //OUVERTURE ET LECTURE DE FICHIER
        public void OpenFile()
        {
            string path = @"c:\temp\MyTest.txt";

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

        public void WriteFile()
        {
            
            string path = @"c:\temp\MyTest.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);

            // Open the file to read from.
            //string readText = File.ReadAllText(path);
            //Console.WriteLine(readText);
        }

        public string PopulateJson()
        {
          return JsonConvert.SerializeObject(formationViewModel);
        }
       
    }
}
