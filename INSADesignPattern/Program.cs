using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern
{
    class Program
    {
        public static string UserName = "You";
        
        static void Main(string[] args)
        {
            string line;
            Observable.Obersver obs = new Observable.Obersver();

            Console.WriteLine("                                     ");
            Console.WriteLine("     __   __     __  ________  _____ ");
            Console.WriteLine("    /  / /  |  /  / /  _____/ /  _  |");
            Console.WriteLine("   /  / /   | /  / /  /____  /  /_| |");
            Console.WriteLine("  /  / /    |/  / /____   / /  ___  |");
            Console.WriteLine(" /  / /  /|    / _____/  / /  /   | |");
            Console.WriteLine("/__/ /__/ |___/ /_______/ /__/    |_|");
            Console.WriteLine("Desing Patterns - Anthony Maudry amaudry@gmail.com");
            Console.WriteLine("Hello,");
            Console.WriteLine("Write something (type 'exit' to exit the program).");

            Observable.Hello hello = new Observable.Hello();
            Observable.Smiley smile = new Observable.Smiley();
            obs.OnEvent("hi", smile);
            obs.OnEvent("hello", smile);
            obs.OnEvent("hello", hello);
            //obs.OnEvent("hi", smile);
            

            while ((line = Console.ReadLine()) != "exit")
            {
                if (!obs.trigger(line))
                {
                    Console.WriteLine(UserName + " wrote : ");
                    Console.WriteLine(line);
                }

            }

            Console.WriteLine("Goodbye.");
        }
    }
}
