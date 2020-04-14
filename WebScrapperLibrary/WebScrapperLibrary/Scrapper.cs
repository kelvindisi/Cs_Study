using System.Net;
using System;
using System.IO;

namespace WebScrapperLibrary
{
    public class Scrapper
    {
        private string getWeb(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

        public string ScrapWebsite(String url)
        {
            return getWeb(url);
        }
        public string ScrapAndSabeWebsite(String url, String path)
        {
            string response = getWeb(url);

            File.WriteAllText(path, response);
            return response;
        }
    }
}
