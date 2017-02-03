using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Invoice
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        private double total;
        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = Price * Quantity;
            }
        }
        //ToString()
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
