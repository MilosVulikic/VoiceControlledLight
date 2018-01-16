using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceControlledLight
{

    class SwitchOnCommand : ICommand
    {
        private Light _light;

        public SwitchOnCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void Undo()
        {
            // _light.TurnOff();    // no need to undo SwitchOn
        }
    }

}