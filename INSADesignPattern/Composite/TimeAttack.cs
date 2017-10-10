using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Observer;

namespace INSADesignPattern.Composite
{
    class TimeAttack : IMenuItems
    {
        public bool Execute()
        {
            Console.WriteLine("C'est parti ! (mode chronométré)");
            return true;
        }

        public string GetDescription(int level = 0)
        {
            string description = "Chronométré <" + GetKeyWord() + ">";
            if(level > 0)
            {
                List<IMenuItems> items = new List<IMenuItems>();
                foreach (IMenuItems item in items)
                {
                    description = description + "\n" + "\t" + item.GetDescription();
                }
            }
            return description;
        }

        public string GetKeyWord()
        {
            return "timed";
        }

        public IObservable GetObservable()
        {
            return null;
        }
    }
}
