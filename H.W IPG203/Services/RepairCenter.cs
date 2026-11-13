using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W_IPG203
{
    internal class RepairCenter
    {
        private List<Appliance> devices = new List<Appliance>();

        public bool AddDevice(Appliance appliance)
        {
            if (appliance != null)
            {
                if (FindDevice(appliance.SerialNumber) != null)
                {
                    return false;
                }

                devices.Add(appliance);

                appliance.StatusChanged += Appliance_StatusChanged;
                return true;
            }
            return false;
        }

        public Appliance FindDevice(string serialNumber)
        {
            foreach (Appliance appliance in devices)
            {
                if (appliance.SerialNumber == serialNumber)
                {
                    return appliance;
                }
            }
            return null;
        } 

        public void DisplayAllDevices()
        {
            if (devices.Count == 0)
            {
                Console.WriteLine("No devices found");
                return;
            }

            foreach (Appliance appliance in devices)
            {
                appliance.DisplayInfo();
                Console.WriteLine("-------------------------");
            }
        }

        public int GetTotalDevices()
        {
            return devices.Count;
        }

        private void Appliance_StatusChanged(Appliance appliance)
        {
            Console.WriteLine("The maintenance status of " + appliance.DeviceName +
            " has changed to: " + appliance.MaintenanceStatus);
        }
    }
}
