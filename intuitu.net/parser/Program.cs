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

        static void Main(string[] args)
        {
        }
    }
}
