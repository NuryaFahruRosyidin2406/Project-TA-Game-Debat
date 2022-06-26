using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip interuptSound, countingScore, congrastSound;
    static AudioSource audioSrc;

    void Start()
    {
        interuptSound = Resources.Load<AudioClip>("SoundEffect/Interupsi");
        countingScore = Resources.Load<AudioClip>("SoundEffect/ScoreCount");
        congrastSound = Resources.Load<AudioClip>("SoundEffect/Congrats");

        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

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

    public static void StopSound()
    {
        audioSrc.Stop();
    }
}
