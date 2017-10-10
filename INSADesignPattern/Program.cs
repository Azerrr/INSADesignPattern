using INSADesignPattern.InputStrategies;
using INSADesignPattern.Observables;
using INSADesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern
{
    class Program
    {
        public static Observer.Observer UserInputObserver;
        private static HelloObservable helloObservable;
        public static string UserName = "<User>";

        private static int countHellos = 0;

        public static void UserSaidHello()
        {
            countHellos++;
            Debug.WriteLine(countHellos);
            switch (countHellos)
            {
                case 5:
                    helloObservable.SetInputStrategy(new LastHelloStrategy());
                    break;
                case 1:
                    helloObservable.SetInputStrategy(new SecondHelloStrategy());
                    break;
            }
        }

        static void Main(string[] args)
        {
            UserInputObserver = new Observer.Observer();
            SmileyObservable smileyObservable = new SmileyObservable();

            string line = "";
            Console.WriteLine("");
            Console.WriteLine("     __   __     __  ________  _____");
            Console.WriteLine("    /  / /  |  /  / /  _____/ /  _  |");
            Console.WriteLine("   /  / /   | /  / /  /____  /  /_| |");
            Console.WriteLine("  /  / /    |/  / /____   / /  ___  |");
            Console.WriteLine(" /  / /  /|    / _____/  / /  /   | |");
            Console.WriteLine("/__/ /__/ |___/ /_______/ /__/    |_|");
            Console.WriteLine("Desing Patterns - Anthony Maudry amaudry@gmail.com");
            Console.WriteLine("Hello,");

            UserInputObserver.Register("hi", smileyObservable);

            List<Composite.IMenuItems> MenuItemList = new List<Composite.IMenuItems>();
            MenuItemList.Add(new Composite.Menu());
            MenuItemList.Add(new Composite.TimeAttack());
            MenuItemList.Add(new Composite.Score());
            MenuItemList.Add(new Composite.QuickGame());
            MenuItemList.Add(new Composite.Infinite());
            MenuItemList.Add(new Composite.Goal());
            MenuItemList.Add(new Composite.GameMode());

            foreach (Composite.IMenuItems item in MenuItemList)
            {
                UserInputObserver.Register(item.GetKeyWord(), item);
            }

            do
            {
                if (line != "" && !UserInputObserver.Trigger(line))
                    Console.WriteLine($"You wrote {line}");

                Console.WriteLine($"\n{UserName}, write something or type 'exit' to exit the program.");
            } while ((line = Console.ReadLine()) != "exit");

            Console.WriteLine("Goodbye.");
        }
    }
}
