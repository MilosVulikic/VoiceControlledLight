using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Speech.Recognition;



namespace VoiceControlledLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use voice commands: \"Turn On/Off\", \"Light/s On/Off\", \"Turn Light/s On/Off\" ");
            Console.WriteLine("Note: Say \"Exit\" or \"Close\" to exit the program.");

            SpeechSynthesizer speechSynt = new SpeechSynthesizer();
            speechSynt.SelectVoiceByHints(VoiceGender.Female);
            speechSynt.Speak("Welcome. Command light with your voice");

            User user = new User();
            user.Engine.SpeechRecognized += Engine_SpeechRecognized;
            
            Console.Read();
        }

        private static void Engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Light diode = new Light();
            SwitchOnCommand switchOn = new SwitchOnCommand(diode);
            SwitchOffCommand switchOff = new SwitchOffCommand(diode);

            string r = e.Result.Text;
            List<string> on = new List<string>{ "Light On", "Lights On", "Turn On", "Turn Light On", "Turn Lights On" };
            List<string> off = new List<string>{"Light Off", "Lights Off", "Turn Off", "Turn Light Off", "Turn Lights Off" };
            List<string> exit = new List<string>{ "Exit", "Close" };

            if (on.Contains(r))
            {
                switchOn.Execute();
            }
            if (off.Contains(r))
            {
                switchOff.Execute();
            }
            if (exit.Contains(r))
            {
                Environment.Exit(0);
            }
        }
    
        
    }
}
