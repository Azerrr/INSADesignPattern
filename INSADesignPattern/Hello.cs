using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Observable
{
    class Hello : IObservable
    {
        public bool Execute()
        {
            Console.WriteLine("Hello, what's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + ", nice to meet you");
            return true;
        }

    }
}
