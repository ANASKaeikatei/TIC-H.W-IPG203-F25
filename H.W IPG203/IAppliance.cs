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
        private int SerialNumber;
        private string DeviceName;
        private DateTime DateOfReceipt;
        private bool MaintenanceStatus;
        private int MaintenanceCost;

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

