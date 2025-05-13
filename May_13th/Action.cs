using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practices
{
    class SimpleDelegate
    {

        class Action
        {
            
            static void Main()
            {
                Action<int> PrintActionDel = ConsolePrint;
                Action<int> PrintToPrinter = PrinterPrint;

                PrintActionDel(10);
                PrintToPrinter(20);
                Console.Read();
            }

            public static void ConsolePrint(int i)
            {
                Console.WriteLine("Printing to console: " + i);
            }
            public static void PrinterPrint(int i)
            {
                Console.WriteLine("This is to being printed to the printer " );
            }
        }
    }
}
