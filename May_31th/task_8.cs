using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    interface IPrintable
    {
        void Print();
    }
     abstract class Invoice
    {
        public List<string> Products = new List<string>();

        public abstract double CalculateTotal();    
    }
    class RetailInvoice : Invoice, IPrintable
    {

        public override double CalculateTotal() => 1000 + 0.1 * 1000;
        public void Print() =>Console.WriteLine("Retail Invoice Total : "+ CalculateTotal());
    }
    class WholesaleInvoice : Invoice, IPrintable
    {
        public override double CalculateTotal() => 800 + 0.05 * 800;
        public void Print() => Console.WriteLine("Wholesale Invoice Total : " + CalculateTotal());
    }
    class Program
    {
        static void Main()
        {
            IPrintable Invoice = new RetailInvoice();
            Invoice.Print();

            Invoice inv  = new WholesaleInvoice();
            ((IPrintable)inv).Print();
        }
    }
}
