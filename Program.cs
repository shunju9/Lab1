using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Computer myComputer = new Computer();

            
            myComputer.InventoryNumber = 123345;
            myComputer.ProcessorFrequency = 1.5;
            myComputer.HardDriveSize = 400;

            
            myComputer.ShowComputerInfo();

           
            double pricePerGB = 100;
            double storageCost = myComputer.CalculateStorageCost(pricePerGB);

           
            Console.WriteLine($"Стоимость внешней памяти: {storageCost} рублей");
            Console.ReadKey(); 
        }
    }
}
