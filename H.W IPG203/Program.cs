using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H.W_IPG203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepairCenter center = new RepairCenter();

            Refrigerator refrigerator = new Refrigerator("R100", DateTime.Now, 5, true);
            refrigerator.DeviceName = "Samsung";
            refrigerator.MaintenanceCost = 50000;

            WashingMachine washingMachine = new WashingMachine("W200", DateTime.Now, 8, true);
            washingMachine.DeviceName = "LG";
            washingMachine.MaintenanceCost = 30000;

            AirConditioner airConditioner = new AirConditioner("A300", DateTime.Now, 24, true);
            airConditioner.DeviceName = "Gree";
            airConditioner.MaintenanceCost = 40000;


            center.AddDevice(refrigerator);
            center.AddDevice(washingMachine);
            center.AddDevice(airConditioner);

            center.DisplayAllDevices();

            Thread.Sleep(5000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Starting Maintenance... \n");
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();

            refrigerator.StartMaintenance();

            Console.WriteLine("\n Statistics: ");
            Console.WriteLine("Total devices: " + center.GetTotalDevices());
            Console.WriteLine("Devices Under Maintenance: " + Appliance.DevicesUnderMaintenance);

            Console.ReadKey();
        }
    }
}
    

