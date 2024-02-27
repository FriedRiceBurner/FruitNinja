using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceCommands : MonoBehaviour
{
    private KeywordRecognizer _keywordRecognizer;

    private void Start()
    {
        _keywordRecognizer = new KeywordRecognizer(new string[] { "fruit gods" });
        _keywordRecognizer.OnPhraseRecognized += OnPhraseRecognized;
        _keywordRecognizer.Start();
    }

    private static void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Voice command: " + args.text);

        if (args.text == "fruit gods")
        {
            Debug.Log("Successful");
        }
    }

    private void OnDestroy()
    {
        if (_keywordRecognizer == null) return;
        _keywordRecognizer.Stop();
        _keywordRecognizer.Dispose();
    }
}