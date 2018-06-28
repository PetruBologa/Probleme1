using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme1
{
    class Program
    {
        static void Main(string[] args)
        {
            var reguli = new Reguli();
            reguli.DrawLadder(3);
            Console.WriteLine("   ");
            Console.WriteLine("***********");
            Console.WriteLine("   ");
            reguli.Lumanari(8, 1, 2, 2, 3, 4, 5, 5, 5);
            Console.WriteLine("   ");
            Console.WriteLine("***********");
            Console.WriteLine("   ");
            reguli.LogIn();
            Console.WriteLine("   ");
            Console.WriteLine("***********");
            Console.WriteLine("   ");
            //var animal = new Animal("Reptila", "Salbatic", "crocodil", 25, 76, false);
            // animal.Display();           
            var caine = new Caine("Mamifer", "domestic", "Caine", 13, 45, true);
            var caine1 = new Caine("Azor", true, true, 12, "de curte");
            caine.Display();
            // Console.WriteLine(caine.ToString());
            Console.ReadKey();

            var valideaza = new Validator();
            Console.WriteLine("Introduceti username: ");
            string user = Console.ReadLine();
            Console.WriteLine("introduceti parola");
            string password = Console.ReadLine();

                        
        }
    }
}
