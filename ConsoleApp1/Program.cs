using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(knock knock) ... Who´s there?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "! Hope you have a great day ;) (yes/no)");
            string leave = Console.ReadLine();
            if (leave == "yes")
            {
                Console.WriteLine("Great! Enjoy it :))");
            }
            else
            {
                Console.WriteLine("Get some coffee, it will get better :)");
            }

            Console.ReadKey();
        }
    }
}
