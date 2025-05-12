using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_12th
{
    interface IDeviceControl 
    {
        void TurnOn();
        void TurnOff();

    }

    class SmartTV : IDeviceControl
    {
        public void TurnOn()
        {
            Console.WriteLine("Smart TV is now ON.");
        }
        public void TurnOff()
        {
           Console.WriteLine("Smart TV is now OFF.");
        }
    }
    public class  Speaker : IDeviceControl
    {
        public void TurnOn()
        {
            Console.WriteLine("Speaker is now ON.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Speaker is now OFF.");
        }
    }
}


using May_12th;

class Program
{
    static void Main()
    {
        IDeviceControl smartTV = new SmartTV();
        IDeviceControl speaker = new Speaker();
        smartTV.TurnOn();
        speaker.TurnOn();
        smartTV.TurnOff();
        speaker.TurnOff();
    }
}

