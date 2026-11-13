using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W_IPG203
{
    internal class WashingMachine : Appliance
    {
        private int _NumberOfPrograms;
        private bool _IsAutomatic;
        public WashingMachine(string SerialNumber, DateTime dateOfReceipt, int numberOfPrograms, bool isAutomatic) : base(SerialNumber, dateOfReceipt)
        {
            NumberOfPrograms = numberOfPrograms;
            IsAutomatic = isAutomatic;
        }

        public int NumberOfPrograms
        {
            get { return _NumberOfPrograms; }
            set
            {
                if (value > 0)
                {
                    _NumberOfPrograms = value;
                }
            }
        }

        public bool IsAutomatic
        {
            get { return _IsAutomatic; }
            set { _IsAutomatic = value; }
        }

        public override int CalculateRepairCost()
        {
            return MaintenanceCost;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Number of programs: " + NumberOfPrograms);
            Console.WriteLine("Automatic: " + IsAutomatic);
        }
    } 
}
