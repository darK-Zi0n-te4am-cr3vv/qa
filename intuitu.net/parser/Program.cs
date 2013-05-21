using System;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace QA.Inituitu.Net.Parser
{
    class Program
    {
        private static HtmlDocument DownloadDocument(string url)
        {
            var web = new HtmlWeb();
            return web.Load(url);
        }

        private static int GetLastPageIndex(HtmlDocument doc)
        {
            var lastPageLink = doc.DocumentNode
                                  .SelectNodes("//li[@class='pager-last last']/a")
                                  .Single()
                                  .GetAttributeValue("href", null);

            return Int32.Parse(Regex.Match(lastPageLink, @"\?page=(\d+)").Groups[1].Value);
        }

        static void Main(string[] args)
        {
            const string baseUrl =
                "http://www.intuitu.net/category/Kategorii-slovarei/Protokoly-bezopasnogo-setevogo-vzaimodeistviYa";

            var baseDoc = DownloadDocument(baseUrl);

            var lastPageIndex = GetLastPageIndex(baseDoc);

            Console.WriteLine(lastPageIndex);
        }
    }
}
