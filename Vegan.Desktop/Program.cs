using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vegan.Database;
using Vegan.Entities.Home;

namespace Vegan.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase myDatabase = new MyDatabase();


            foreach (var item in myDatabase.Candles)
            {
                Console.WriteLine(item.Title);
            }

            Console.WriteLine("--------------------------");


            foreach (var item in myDatabase.Homes)
            {
                Console.WriteLine(item.Title);
            }

            Console.WriteLine("--------------------------");

            foreach (var item in myDatabase.Chocolates)
            {
                Console.WriteLine(item.Title);
            }

            Console.ReadLine();


        }
    }
}
