using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W_IPG203
{
    internal static class ApplianceValidator
    {
        public static bool IsValidSerialNumber(string serialNumber)
        {
            if (serialNumber != null && serialNumber != "") 
            {
                return true;
            }
            return false;
        }

        public static bool IsValidDate(DateTime date)
        {
            if(date <= DateTime.Now && date != DateTime.MinValue)
            {
                return true;
            }
            return false;
        }
    }
}
