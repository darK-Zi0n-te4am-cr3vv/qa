using System;
using System.IO;
using System.Linq;
using System.Text;
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

        private static void ParsePage(HtmlDocument doc, TextWriter outputWriter)
        {
            var qas = doc.DocumentNode.SelectNodes("//div[@class='view-content']/div/div[@class='node']");

            foreach (var qa in qas)
            {
                var q = qa.SelectSingleNode(".//h2[@class='title']/a/text()")
                          .InnerText;

                var contentNode = qa.SelectSingleNode(".//div[@class='content']/p/p");

                // FIXME: Workaround.
                if (contentNode == null) continue;

                var a = contentNode.ChildNodes;

                // Title
                outputWriter.WriteLine(q);
                outputWriter.WriteLine(new String('-', q.Length));
                outputWriter.WriteLine();

                // Body
                foreach (var ans in a.Where(ans => ans.NodeType == HtmlNodeType.Text))
                {
                    var text = ans.InnerText.Trim();

                    // Some nods are empty; skipping.
                    if (text == "") continue;

                    var correct = ans.PreviousSibling != null &&
                                  ans.PreviousSibling.NodeType == HtmlNodeType.Element &&
                                  ans.PreviousSibling.Name == "span";

                    outputWriter.WriteLine(" - {0}{1}{0}", correct ? "**" : "", text);
                }

                outputWriter.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            const string baseUrl =
                "http://www.intuitu.net/category/Kategorii-slovarei/Protokoly-bezopasnogo-setevogo-vzaimodeistviYa";

            var baseDoc = DownloadDocument(baseUrl);

            var lastPageIndex = GetLastPageIndex(baseDoc);

            Console.WriteLine(lastPageIndex);
            ParsePage(baseDoc, Console.Out);
        }
    }
}
