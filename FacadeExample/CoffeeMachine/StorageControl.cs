using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.CoffeeMachine
{
    internal class StorageControl
    {
        public void GetCoffee(int espressoShots)
        {
            Console.WriteLine("Added {0} shots of espresso", espressoShots);
        }
    }
}
