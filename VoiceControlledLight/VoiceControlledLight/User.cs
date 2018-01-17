using System.Speech.Recognition;
class User
{
    SpeechRecognitionEngine _engine = new SpeechRecognitionEngine();

    public SpeechRecognitionEngine Engine
    {
        get { return _engine; }        
    }

    public User()
    {
        _engine.SetInputToDefaultAudioDevice();
        Grammar grammar = LightControlGrammar.GetGrammar();
        _engine.LoadGrammar(grammar);
        _engine.RecognizeAsync(RecognizeMode.Multiple);        
    }

}