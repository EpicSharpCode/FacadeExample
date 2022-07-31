using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.CoffeeMachine
{
    internal class MilkControl
    {
        public void GetMilk(float litres)
        {
            Console.WriteLine("Added {0} liters of milk", litres);
        }
    }
}
