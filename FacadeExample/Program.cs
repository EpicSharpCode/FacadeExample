using FacadeExample.CoffeeMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeaterControl heaterControl = new HeaterControl();
            WaterControl waterControl = new WaterControl();
            MilkControl milkControl = new MilkControl();
            StorageControl storageControl = new StorageControl();

            CoffeeMachineFacade coffeeMachineFacade = new CoffeeMachineFacade(heaterControl, waterControl, milkControl, storageControl);

            coffeeMachineFacade.MakeEspresso();
            Console.WriteLine("");
            coffeeMachineFacade.MakeFlatWhite();

            Console.ReadLine();
        }
    }
}
