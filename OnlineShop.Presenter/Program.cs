using System;
using System.Linq;
using Shop.Domain;
using Shop.structure;

namespace Shop.Presenter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                Console.ReadLine();
            }
        }
    }
}
