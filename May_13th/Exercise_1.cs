using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practices
{
    interface ITransport 
    {
        void Start();
        void Stop();
    }

    class Bus : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Bus is starting.");
        }
        public void Stop()
        {
            Console.WriteLine("Bus is stopping.");
        }
    }
    class Train : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Train is starting.");
        }
        public void Stop()
        {
            Console.WriteLine("Train is stopping.");
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Linq_Practices
{
    class Program
    {
        static void Main()
        {
            // Create an instance of Bus and Train
            ITransport bus = new Bus();
            ITransport train = new Train();
            // Start and stop the bus
            bus.Start();
            bus.Stop();
            // Start and stop the train
            train.Start();
            train.Stop();
        }
    }
}
