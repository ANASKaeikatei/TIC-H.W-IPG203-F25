using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W_IPG203
{
    internal class Refrigerator : Appliance
    {
        private int _Temperature;
        private bool _IsFreezerAvailable;

        public Refrigerator(string SerialNumber, DateTime dateOfReceipt, int temperature, bool isFreezerAvailable) :base(SerialNumber, dateOfReceipt)
        {
            Temperature = temperature;
            IsFreezerAvailable = isFreezerAvailable;
        }

        public int Temperature
        {
            get { return _Temperature; }
            set
            {
                if (value >= -30 && value <= 10)
                {
                    _Temperature = value;
                }
            }
        }

        public bool IsFreezerAvailable
        {
            get { return _IsFreezerAvailable; }
            set { _IsFreezerAvailable = value; }
        }

        public override int CalculateRepairCost()
        {
            return MaintenanceCost;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine("Freezer Available: " + IsFreezerAvailable);
        }
    }
}
