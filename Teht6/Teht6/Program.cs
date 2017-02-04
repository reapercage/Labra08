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
        private double price;
        //private int quantity;
        public double Price { get { return price; } set { price = value; } }
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
            return Name + " " + Price + "e " + Quantity + " pieces " + total + "e total";
        }
        //ToString()
    }
    class Invoice : InvoiceItem
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
        public InvoiceItem FindItem(int index)
        {
            if(index < invoice.Count)
            {
                return invoice.ElementAt(index);
            }
            else
            {
                return null;
            }
        }
        public double Total
        {
            get { return Total; }
            set
            {
                for(int i = 0; i < invoice.Count(); i++)
                {
                    total = total + Ostokset[i].Total;
                }
            }
        }
        public void PrintInvoice()
        {
            Console.WriteLine("Customer " + Customer + "'s invoice:");
            Console.WriteLine("==================================");
            foreach (InvoiceItem i in invoice)
            {
                Console.WriteLine(i.ToString());
            }
            Total = 1;
            Console.WriteLine("==================================");
            Console.WriteLine("Total : " + total + " euros");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice ostoskori = new Invoice();
            ostoskori.Customer = "Pertti Keinonen";
            InvoiceItem ostos = new InvoiceItem { Name = "Eggs", Price = 1.40, Quantity = 2, Total = 1 };
            InvoiceItem ostos2 = new InvoiceItem { Name = "Bread", Price = 2.19, Quantity = 3, Total = 1 };
            InvoiceItem ostos3 = new InvoiceItem { Name = "Juice", Price = 1.79, Quantity = 1, Total = 1 };
            ostoskori.AddItem(ostos);
            ostoskori.AddItem(ostos2);
            ostoskori.AddItem(ostos3);
            ostoskori.PrintInvoice();
            

            Console.ReadKey();
        }
    }
}
