using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Computer
    {
        public int InventoryNumber;
        public double ProcessorFrequency; 
        public int HardDriveSize; 

        public void ShowComputerInfo()
        {
            Console.WriteLine("Информация о компьютере:");
            Console.WriteLine($"Инвентарный номер: {InventoryNumber}");
            Console.WriteLine($"Частота процессора: {ProcessorFrequency} ГГц");
            Console.WriteLine($"Объем жесткого диска: {HardDriveSize} Гб");
        }

        public double CalculateStorageCost(double pricePerGB)
        {
            return HardDriveSize * pricePerGB;
        }
    }
}

