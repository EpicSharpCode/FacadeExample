using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.CoffeeMachine
{
    internal class HeaterControl
    {
        public void Heat(int temp)
        {
            Console.WriteLine("Water heating up to {0} degrees", temp);
        }
    }
}
