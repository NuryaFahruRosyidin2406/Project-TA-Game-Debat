using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    // Creates a static varible for a MusicControlScript instance
    public static MusicControl instance; 

    // Initialized audio source variable
    AudioSource audioSource;

    // Runs before void Start()
    private void Awake() 
    {
        // If the MusicControlScript instance variable is null
        if (instance == null) 
        {
            // Set this object as the instance
            instance = this; 
        }
        else // If there is already a MusicControlScript instance active
        {
            // Destroy this gameObject
            Destroy(gameObject);
        }

        // Get the AudioSource from the object
        audioSource = GetComponent<AudioSource>();
    }

    // Mute/Unmute the Game Audio
    public void MuteAudio()
    {
        audioSource.mute = !audioSource.mute;
    }
}
