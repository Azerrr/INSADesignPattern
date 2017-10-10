using INSADesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Composite
{
    interface IMenuItems : IObservable
    {
        string GetDescription(int level = 0);
        IObservable GetObservable();
        string GetKeyWord();
    }
}
