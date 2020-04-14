using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScrapperLibrary;

namespace ClassLibraryUse
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrapper scrapper = new Scrapper();
            string url = "http://msdn.microsoft.com";
            string path = @"C:\C#Files\jkuatuni.html";

            Console.WriteLine(scrapper.ScrapWebsite(url));
            //Console.WriteLine(scrapper.ScrapAndSabeWebsite(url, path));
            Console.ReadKey();
        }
    }
}
