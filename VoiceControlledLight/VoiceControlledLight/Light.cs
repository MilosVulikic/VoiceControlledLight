using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace VoiceControlledLight
{
    class Light
    {
        SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);


        public void TurnOn()
        {
            port.Open();
            port.WriteLine("O");    // On
            port.Close();
            Console.WriteLine("Light is On");
        }
        public void TurnOff()
        {
            port.Open();
            port.WriteLine("X");    // Off
            port.Close();
            Console.WriteLine("Light is Off");
        }
    }
}