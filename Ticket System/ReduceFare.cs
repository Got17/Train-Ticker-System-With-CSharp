using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_System
{
    internal class ReduceFare
    { 
        public static string Senior(RadioButton radioButton)
        {
            double discount = Pay.pay * 0.5;

            Pay.pay -= Convert.ToDouble(discount);

            return $"Senior ticket 50% discount: {Pay.pay} €\n";
        }
        public static string Kid(RadioButton radioButton)
        {

            double discount = Pay.pay * 0.2;
            Pay.pay -= Convert.ToDouble(discount);

            return $"Senior ticket 20% discount: {Pay.pay} €\n";
        }
        public static string NoDiscount(RadioButton radioButton)
        {

            return $"no travel discount: {Pay.pay} €\n";
        }
    }
}
