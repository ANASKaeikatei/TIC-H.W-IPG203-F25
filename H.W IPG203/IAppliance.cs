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
        private  readonly string _SerialNumber;
        private string _DeviceName;
        private DateTime _DateOfReceipt;
        private bool _MaintenanceStatus;
        private int _MaintenanceCost;

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

        public string SerialNumber
        {
            get { return _SerialNumber; }
        }

        public string DeviceName
        {
            get { return _DeviceName; }
            
            set
            { 
                if ( _DeviceName == null )
                {
                    _DeviceName = value;
                }
            }
        }

        public DateTime DateOfReceipt
        {
            get { return _DateOfReceipt; }
            private set { _DateOfReceipt = value; } 
        }

        public bool MaintenanceStatus
        {
             get { return _MaintenanceStatus; }
        }
       public int MaintenanceCost
       {
           get { return _MaintenanceCost; }
           set
           {
               if (value >= 0)
               {
                   _MaintenanceCost = value;
               }
           }
       }


    }
}

