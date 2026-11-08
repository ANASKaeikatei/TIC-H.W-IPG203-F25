using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W_IPG203
{
    internal interface IAppliance
    {
        bool StartMaintenance();
        bool CompleteMaintenance();
        void DisplayInfo();
    }

    internal abstract class Appliance : IAppliance
    {
        public int SerialNumber;
        public string DeviceName;
        public DateTime DateOfReceipt;
        public bool MaintenanceStatus;
        public int MaintenanceCost;

        public abstract int CalculateRepairCost();

        bool IAppliance.CompleteMaintenance()
        {
          return false;
        }

        void IAppliance.DisplayInfo()
        {
            
        }

        bool IAppliance.StartMaintenance()
        {
            return false;
        }
    }
}

