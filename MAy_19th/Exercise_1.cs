using System;
using System.Collections.Generic;

public abstract class SmartDevice
{
    public abstract void TurnOn();
     void ShowStatus()
    {
        Console.WriteLine("Device status : Active");
    }
}
interface IRemoteControl
{
    void IncreaseVolume();
    void DecreaseVolume();
}
public class SmartLight : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Light is turned on.");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Light do not support volume control.");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Light do not support volume control.");
    }

    public class SmartSpeaker : SmartDevice, IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart Speaker is turned on.");
        }
        public void IncreaseVolume()
        {
            Console.WriteLine("Volume increased.");
        }
        public void DecreaseVolume()
        {
            Console.WriteLine("Volume decreased.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<SmartDevice> devices = new List<SmartDevice>
            {
                new SmartLight(),
                new SmartSpeaker()
            };
            foreach (var device in devices)
            {
                device.TurnOn();
                if (device is IRemoteControl remoteControl)
                {
                    remoteControl.IncreaseVolume();
                    remoteControl.DecreaseVolume();
                }
            }
        }
    }
}