using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W_IPG203
{
    internal class WashingMachine : Appliance
    {
        public WashingMachine(string SerialNumber, DateTime dateOfReceipt) : base(SerialNumber, dateOfReceipt)
        {
            
        }

        public override int CalculateRepairCost()
        {
            return 1;
        }
        
    } 
}
