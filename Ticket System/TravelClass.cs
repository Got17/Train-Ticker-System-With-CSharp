using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_System
{
    internal class TravelClass
    {
        public static string FirstClass(ComboBox travelClassCb)
        {
            double priceIncrease = Pay.pay * 0.2;
            Pay.pay += Convert.ToDouble(priceIncrease);
            return $"first class 20% surchange: {Pay.pay} €\n";
        }
        public static string BusinessClass(ComboBox travelClassCb)
        {
            double priceIncrease = Pay.pay * 0.1;
            Pay.pay += Convert.ToDouble(priceIncrease);
            return $"bussiness class 10% surchange: {Pay.pay} €\n";
        }
        public static string EconomyClass(ComboBox travelClassCb)
        {
            return $"There is no extra costs for Economy class\n";
        }
    }
}
