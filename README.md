# VoiceControlledLight

This is a very simple program which uses voice control (using System.Speech.Recognition) to turn light diode on/off (conected to Arduino board). In this example **Command pattern** is implemented.
Program consists of 2 parts:
* [VoiceControlledLight](https://github.com/MilosVulikic/VoiceControlledLight/tree/master/VoiceControlledLight/VoiceControlledLight)
* [Arduino files](https://github.com/MilosVulikic/VoiceControlledLight/tree/master/VoiceControlledLight/VoiceControlledLight/External%20Files/VoiceControlledDiode)

## Getting Started

In order to use this application properly, you need to have microcontroller which will handle the message sent through port COM3. Easiest way is to use <b>Arduino</b>.
Your Arduino is set to use <b>pin 13</b>, and will get high or low voltage on that pin according to your given commands. It is suggested to use Diode to react to the voltage change and make this program fullfill its purpose. For more detail how adjust Arduino, look under <b>Installation</b>. After setting up Arduino, you should upload code to it from above mentioned [arduino files](https://github.com/MilosVulikic/VoiceControlledLight/tree/master/VoiceControlledLight/VoiceControlledLight/External%20Files/
Beside Arduino files you need to download exe files provided in [winrar file] (https://github.com/MilosVulikic/VoiceControlledLight/blob/master/VoiceControlledLightExe.rar), or to clone the application. 

## Installation
The Arduino setup is very basic, all you need is one Diode and connect its + side to the pin 13, and - to the Gnd (ground).
You can pin Diode directly in the Arduino pins (13 and Gnd), or use the breadboard, such as shown on the image below.
Next step is to upload the Arduino code to the board. If you don'd have Arduino IDE, you need to install it from [this site](https://www.arduino.cc/en/Main/Software).
Main program is to be started by opening its exe file, or by starting its project through Visual studio and building it.

## Running the tests

Run the program. Read the instructions provided in the console after starting the program. Use any of the commands mentioned in the instructions. 
Depending on your command diode should [turn on] 

Turn On          |  Turn Off
:-------------------------:|:-------------------------:
<img src="https://github.com/MilosVulikic/VoiceControlledLight/blob/master/VoiceControlledLight/VoiceControlledLight/External%20Files/Readme%20files/LightOn.jpg" width="425"/> | <img src="https://github.com/MilosVulikic/VoiceControlledLight/blob/master/VoiceControlledLight/VoiceControlledLight/External%20Files/Readme%20files/LightOff.jpg" width="425"/> 


Voice command list:
```
"Light On", "Lights On"
"Light Off", "Lights Off"
"Turn On", "Turn Light On", "Turn Lights On"
"Turn Off", "Turn Light Off", "Turn Lights Off"
"Exit", "Close"
```
These commands are self explicatory, therefore no more details about testing is provided.

## Versioning

Version 1.0.0. Due to the simplicity of the project no detailed versioning information is provided. 

## Authors

**Milos vulikic** 

## License

This is freeware so feel free to share and use it. 

## Acknowledgments

Idea of making this program is to learn more about Command pattern, Accessing Arduino or external platforms through C#, and learning about Voice Recognition library.

Further possible development:
* Extending Grammar list
* Extending Commands that can be executed
* Scaling Arduino project from very basic to basic/moderate/advanced level 
* Creating GUI 
