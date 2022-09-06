using Presentation.Models;
using System;
using System.Linq;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthwindContext())
            {
                foreach (var item in context.AlphabeticalListOfProducts)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
        }
    }
}
