using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class payments
    {

        public double Payment { get; set; }
        public string Date { get; set; }

        public payments(double payment, string date) {
            Payment = payment;
            Date = date;
        }
        public override string ToString()
        {
            return "$" + Payment + " -> " + (Date.Split(' '))[0];
        }
    }
}
