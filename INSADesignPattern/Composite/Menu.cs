using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Observer;

namespace INSADesignPattern.Composite
{
    class Menu : IMenuItems, IObservable
    {
        public bool Execute()
        {
            Console.WriteLine(GetDescription(1));
            return true;
        }

        public string GetDescription(int level = 0)
        {
            string description = "Menu <" + GetKeyWord() + ">";
            if (level > 0)
            {
                List<IMenuItems> items = new List<IMenuItems>();
                items.Add(new QuickGame());
                items.Add(new GameMode());
                items.Add(new Score());
                foreach (IMenuItems item in items)
                {
                    description = description + "\n" + "\t" + item.GetDescription();
                }
            }
            return description;
        }

        public string GetKeyWord()
        {
            return "menu";
        }

        public IObservable GetObservable()
        {
            return null;
        }
    }
}
