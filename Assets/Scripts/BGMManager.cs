using UnityEngine;

public class BGMManager : MonoBehaviour
{
    Timer BGMTimeInterval;
    AudioSource RainAmbienceAudio;
    AudioSource ThunderAmbienceAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
        GetComponentsInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
