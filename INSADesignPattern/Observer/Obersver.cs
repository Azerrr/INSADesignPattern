using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Observable
{
    class Obersver
    {
        private Dictionary<string, List<IObservable>> ObservableList; //private List<IObservable> ObservableList;

        public Obersver()
        {
            ObservableList = new Dictionary< string, List < IObservable >> (); //List<IObservable>();
        }
        
        public bool OnEvent(string eventString, IObservable instance)
        {
            // If the key doesn't exists, we add it to dictionnary
            if (!ObservableList.ContainsKey(eventString))
            {
                ObservableList.Add(eventString, new List<IObservable>());
            }
            // If the instance is not already registered, we add it to the related list
            if(ObservableList[eventString].Contains(instance))
            {
                Console.Error.WriteLine("This instance is already registered for this event");
                return false;
            }
            else
            {
                ObservableList[eventString].Add(instance);
                return true;
            }
        }
        
        public bool OffEvent(string eventString, IObservable instance)
        {
            return ObservableList[eventString].Remove(instance);
        }

        public bool trigger(string line)
        {
            if(ObservableList.ContainsKey(line))
            {
                foreach(IObservable instance in ObservableList[line])
                {
                    instance.Execute();
                }
                return true;
            }
            return false;
        }
    }
}
