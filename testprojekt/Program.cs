using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace testprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string choice;

            Console.WriteLine("Are you gay? (yes or no)");
            choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                Console.WriteLine("Youre Gay as hell");
            }
            else if (choice == "no")
            {
                Console.WriteLine("stop lying i know you're Gay");
                Console.WriteLine("just admit it and type YES: ");
                string yes = Console.ReadLine().ToUpper();
                while (yes != "YES")
                {
                    Console.WriteLine("TYPE YES DUMBASS");
                    yes = Console.ReadLine().ToUpper();
                    if (yes == "YES")
                    {
                        Console.WriteLine("Knew youre gay");
                    }

                }
            }
            else
            {
                Console.WriteLine("you didnt type yes or no thats gay as hell not gonna lie");
            }
        }
    }
}
