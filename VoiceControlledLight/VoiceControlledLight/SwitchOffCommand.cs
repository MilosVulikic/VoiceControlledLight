using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceControlledLight
{
        class SwitchOffCommand : ICommand
        {
            private Light _light;

            public SwitchOffCommand(Light light)
            {
                this._light = light;
            }

            public void Execute()
            {
                _light.TurnOff();
            }

            public void Undo()
            {
                // _light.TurnOff();    // no need to undo SwitchOff
            }
    }
}





