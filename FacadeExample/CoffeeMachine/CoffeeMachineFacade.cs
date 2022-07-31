using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.CoffeeMachine
{
    internal class CoffeeMachineFacade
    {
        HeaterControl heaterControl;
        WaterControl waterControl;
        MilkControl milkControl;
        StorageControl storageControl;

        public CoffeeMachineFacade(HeaterControl _heaterControl, WaterControl _waterControl, MilkControl _milkControl, StorageControl _storageControl)
        {
            heaterControl = _heaterControl;
            waterControl = _waterControl;
            milkControl = _milkControl;
            storageControl = _storageControl;
        }

        public void MakeEspresso()
        {
            Console.WriteLine("Espresso");
            storageControl.GetCoffee(1);
            waterControl.GetWater(0.2f);
            heaterControl.Heat(60);
        }
        public void MakeFlatWhite()
        {
            Console.WriteLine("Flat White");
            storageControl.GetCoffee(2);
            waterControl.GetWater(0.2f);
            milkControl.GetMilk(0.3f);
            heaterControl.Heat(80);
        }
    }
}
