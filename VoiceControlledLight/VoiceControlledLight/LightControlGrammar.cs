using System;
using System.Speech.Recognition;
static class LightControlGrammar
{
    public static Grammar GetGrammar()
    {
        String[] objects = new string[] { "Light", "Lights" };
        String[] attributes = new String[] { "On", "Off" };
        String[] commands = new String[] { "Turn" };
        String[] commandsExit = new String[] { "Exit", "Close" };

        // Object + Attribute
        GrammarBuilder gbObjAttr = new GrammarBuilder(new Choices(objects));
        gbObjAttr.Append(new Choices(attributes));

        // Command + Attr
        GrammarBuilder gbCmdAttr = new GrammarBuilder(new Choices(commands));
        gbCmdAttr.Append(new Choices(attributes));

        // Command + Object + Attr
        GrammarBuilder gbComObjAttr = new GrammarBuilder(new Choices(commands));
        gbComObjAttr.Append(new Choices(objects));
        gbComObjAttr.Append(new Choices(attributes));

        // Exit commands
        GrammarBuilder gbExitCmd = new GrammarBuilder(new Choices(commandsExit));

        Grammar g = new Grammar(new Choices(gbObjAttr, gbCmdAttr, gbComObjAttr, gbExitCmd));
        return g;
    }
}
