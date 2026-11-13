using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W_IPG203
{
    internal delegate void ApplianceStatusChangedHandler(Appliance appliance);

    internal interface IAppliance
    {
        bool StartMaintenance();
        bool CompleteMaintenance();
        void DisplayInfo();
    }

    internal abstract class Appliance : IAppliance
    {
        private readonly string _SerialNumber;
        private string _DeviceName;
        private DateTime _DateOfReceipt;
        private bool _MaintenanceStatus;
        private int _MaintenanceCost;
        private static int _DeicesUnderMaintenance = 0;

        protected Appliance(string SerialNumber, DateTime date)
        {
            if (ApplianceValidator.IsValidSerialNumber(SerialNumber))
            {
                _SerialNumber = SerialNumber;
            }
            else
            {
                Console.WriteLine("Invaild serial number");
            }

            if (ApplianceValidator.IsValidDate(date))
            {
                _DateOfReceipt = date;
            }
            else
            {
                Console.WriteLine("Invaild date");
            }
        }

        public event ApplianceStatusChangedHandler StatusChanged;

        public abstract int CalculateRepairCost();

        protected void ChangeStatus(bool newStatus)
        {
            if(_MaintenanceStatus != newStatus)
            {
                if(newStatus == true)
                {
                    _DeicesUnderMaintenance++;
                }
                else
                {
                    _DeicesUnderMaintenance--;
                }
                _MaintenanceStatus = newStatus;
                StatusChanged?.Invoke(this);
            }
        }

        bool IAppliance.CompleteMaintenance()
        {
            if (!_MaintenanceStatus)
            {
                return false;
            }

            ChangeStatus(false);
            return true;
        }

        void IAppliance.DisplayInfo()
        {
            Console.WriteLine("Device Name: " + DeviceName);
            Console.WriteLine("Serial Number: " + SerialNumber);
            Console.WriteLine("Maintenance Status: " + MaintenanceStatus);
            Console.WriteLine("Maintenance Cost: " + MaintenanceCost);
        }

        bool IAppliance.StartMaintenance()
        {
            if (_MaintenanceStatus)
            {
                return false;
            }

            ChangeStatus(true);
            return true;
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
                if (_DeviceName == null)
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

        public static int DevicesUnderMaintenance
        {
            get { return _DeicesUnderMaintenance; }
        }
    }
}