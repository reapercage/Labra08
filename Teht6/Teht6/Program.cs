using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class InvoiceItem
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
        public override string ToString()
        {
            return Name + " " + Price + "e " + Quantity + "kpl " + total + "total";
        }
        //ToString()
    }
    class Invoice
    {
        private double total;
        public string Customer { get; set; }
        private List<InvoiceItem> invoice;
        public List<InvoiceItem> Ostokset
        {
            get { return invoice; }
        }
        public Invoice()
        {
            invoice = new List<InvoiceItem>();
        }
        public void AddItem(InvoiceItem ini)
        {
            invoice.Add(ini);
        }
        public double Total
        {
            get { return Total; }
            set
            {
                for(int i = 0; i < invoice.Count(); i++)
                {
                    total = total + invoice[i].Total;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice ostoskori = new Invoice();
            ostoskori.Customer = "Pertti Keinonen";
            InvoiceItem ostos = new InvoiceItem { Name = "Eggs", Price = 1.40, Quantity = 1 };
            ostoskori.AddItem(ostos);
            Console.WriteLine(ostos.ToString());
            Console.ReadKey();
        }
    }
}
