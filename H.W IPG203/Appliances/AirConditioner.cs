using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W_IPG203
{
    internal class AirConditioner : Appliance
    {
        private int _Temperature;
        private bool _IsHeatingAvailable;
        public AirConditioner(string SerialNumber, DateTime dateOfReceipt, int temperature, bool isHeatingAvailable) : base(SerialNumber, dateOfReceipt)
        {
            Temperature = temperature;
            IsHeatingAvailable = isHeatingAvailable;
        }

        public int Temperature
        {
            get {  return _Temperature; }
            set 
            {
                if (value >= 16 && value <= 30)
                {
                    _Temperature = value;
                }
            }
        }

        public bool IsHeatingAvailable
        {
            get { return _IsHeatingAvailable; }
            set {  _IsHeatingAvailable = value; }
        }

        public override int CalculateRepairCost()
        {
            return MaintenanceCost;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine("Heating Available: " + IsHeatingAvailable);
        }
    }
}
