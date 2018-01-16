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
            SwitchOnCommand switchOn = new SwitchOnCommand(diode);
            SwitchOffCommand switchOff = new SwitchOffCommand(diode);

            while (true)
            {
                Console.WriteLine("Enter O = On, X = Off:");
                string a = Console.ReadLine();
                if (a == "O")
                {
                    switchOn.Execute();
                }
                else if (a == "X")
                {
                    switchOff.Execute();

                }
                else break;
                
            }
                        
        }
    }
}
