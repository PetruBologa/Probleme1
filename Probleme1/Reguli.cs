using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme1
{
    class Reguli
    {
        public void DrawLadder(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public void Lumanari(int age, params int[] inaltimeLumanari)
        {
            int highestCandle = 1;
            int apearances = 1;
            for (int i = 0; i < age; i++)
            {
                if (inaltimeLumanari[i] > highestCandle)
                {
                    highestCandle = inaltimeLumanari[i];
                    apearances = 1;
                }
                else if (inaltimeLumanari[i] == highestCandle)
                {
                    apearances++;
                }

            }

            Console.WriteLine($"Varsta {age}");
            foreach (var item in inaltimeLumanari)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Numar lumanari stinse : {apearances}");
        }


        public void LogIn()
        {
            string user;
            string password;
            int incercari = 1;

            Console.WriteLine("Please select user name:");
            user = Console.ReadLine();
            Console.WriteLine("Please select password:");
            password = Console.ReadLine();
            Console.WriteLine("*************************");
            Console.WriteLine("Please reenter information to log in:");

            Console.WriteLine("User");
            string userattempt = Console.ReadLine();
            Console.WriteLine("Password");
            string passattepmt = Console.ReadLine();
            bool logged = false;
            while (incercari <= 3)
            {
                if (userattempt == user && passattepmt==password)
                {                    
                    Console.WriteLine("Congratulations you are now logged in!!");
                    logged = true;
                    break;
                    
                }
                else
                {
                    incercari++;
                    Console.WriteLine("Incorrect name and password, please try again!");
                    Console.WriteLine("User");
                    userattempt = Console.ReadLine();
                    Console.WriteLine("Password");
                    passattepmt = Console.ReadLine();
                }             
                

            }
            if (logged == false && incercari == 3)
            {
                Console.WriteLine("No more attempts remaining please contact system administrator!");
            }

        }

      
    }
    public class Validator
    {
        private string TrueUsername = "yanek";
        private string TruePassword = "verysecretpassword";
        private int contor = 0;

        public bool Valideaza(string username, string parola)
        {
            if (TrueUsername == username %% TruePassword == parola)
            {
                return true;
            }
            else
            {
                contor++;
                return false;
            }
        }
    }
}
