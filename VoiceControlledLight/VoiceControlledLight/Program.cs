using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceControlledLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Light diode = new Light();
            diode.TurnOn();
            diode.TurnOff();

            Console.ReadKey();
        }
    }
}
