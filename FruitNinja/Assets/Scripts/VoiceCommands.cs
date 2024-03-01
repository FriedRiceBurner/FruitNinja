using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Windows.Speech;

public class VoiceCommands : MonoBehaviour
{
    private KeywordRecognizer _keywordRecognizer;
    public Material moldyMaterial;
    public GameObject player;
    private void Start()
    {
        _keywordRecognizer = new KeywordRecognizer(new string[] { "fruit gods" });
        _keywordRecognizer.OnPhraseRecognized += OnPhraseRecognized;
        _keywordRecognizer.Start();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Voice command: " + args.text);

        if (args.text == "fruit gods")
        {
            enemy_movement[] enemies = FindObjectsByType<enemy_movement>(FindObjectsSortMode.None);
            foreach (enemy_movement enemy in enemies)
            {
                // Check if the enemy contains the enemy_movement script
                if (enemy.GetComponent<enemy_movement>() != null)
                {
                    // Access the renderer and change the material
                    Renderer renderer = enemy.GetComponent<Renderer>();
                    if (renderer != null)
                    {
                        renderer.material = moldyMaterial;
                        enemy.speed = 0f;
                        Seed_Shooter[] seedShooters = FindObjectsByType<Seed_Shooter>(FindObjectsSortMode.None);
                        foreach (Seed_Shooter seedShooter in seedShooters)
                        {
                            seedShooter.rate_of_fire = 100;
                        }
                    }
                }
            }
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