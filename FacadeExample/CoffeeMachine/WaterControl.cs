using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.CoffeeMachine
{
    internal class WaterControl
    {
        public void GetWater(float litres)
        {
            Console.WriteLine("Added {0} liters of water", litres);
        }
    }
}
