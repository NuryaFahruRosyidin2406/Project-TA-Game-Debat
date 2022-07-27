using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Creates a static varible for the audio
    public static AudioClip interuptSound, countingScore, congrastSound;
    static AudioSource audioSrc;

    void Start()
    {
        // Load the audio source into the variables
        interuptSound = Resources.Load<AudioClip>("SoundEffect/Interupsi");
        countingScore = Resources.Load<AudioClip>("SoundEffect/ScoreCount");
        congrastSound = Resources.Load<AudioClip>("SoundEffect/Congrats");

        // Get the audio component
        audioSrc = GetComponent<AudioSource>();
    }

    // Play the audio base on its case
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "interupsi":
                audioSrc.PlayOneShot(interuptSound);
                break;
            case "scorecount":
                audioSrc.PlayOneShot(countingScore);
                break;
            case "congrats":
                audioSrc.PlayOneShot(countingScore);
                break;
        }
    }

    // Stop the audio
    public static void StopSound()
    {
        audioSrc.Stop();
    }
}
