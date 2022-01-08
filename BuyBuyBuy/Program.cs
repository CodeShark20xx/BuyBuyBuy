using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace BuyBuyBuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                string product = "books";
                HtmlDocument htmlDocument = web.Load("https://google.com/search?q=buy+" + product);
                HtmlNodeCollection itemsContainerNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='top-pla-group-inner']");
                HtmlNode itemsContainerNode = itemsContainerNodeCollection.First();
                HtmlNodeCollection itemsNodeCollection = itemsContainerNode.ChildNodes;

                foreach (HtmlNode itemNode in itemsContainerNodeCollection)
                {
                    Console.WriteLine(itemNode.InnerText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
            }

            Console.ReadLine();
        }
    }
}
