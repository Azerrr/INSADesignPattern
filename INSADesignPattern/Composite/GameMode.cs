using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Observer;

namespace INSADesignPattern.Composite
{
    class GameMode : IMenuItems
    {
        public bool Execute()
        {
            Console.WriteLine(GetDescription(1));
            return true;
        }

        public string GetDescription(int level = 0)
        {
            string description = "Type de partie <" + GetKeyWord() + ">";
            if (level > 0)
            {
                List<IMenuItems> items = new List<IMenuItems>();
                items.Add(new TimeAttack());
                items.Add(new Infinite());
                items.Add(new Goal());
                foreach (IMenuItems item in items)
                {
                    description = description + "\n" + "\t" + item.GetDescription();
                }
            }
            return description;
        }

        public string GetKeyWord()
        {
            return "type";
        }

        public IObservable GetObservable()
        {
            return null;
        }
    }
}
