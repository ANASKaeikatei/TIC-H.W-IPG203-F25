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

        public void AddDevice(Appliance appliance)
        {
            if (appliance != null)
            {
                devices.Add(appliance);

                appliance.StatusChanged += Appliance_StatusChanged;
            }
        }

        private void Appliance_StatusChanged(Appliance appliance)
        {
            Console.WriteLine("The maintenance status of " + appliance.DeviceName +
                " has changed to: " + appliance.MaintenanceStatus);
        }
    }
}
