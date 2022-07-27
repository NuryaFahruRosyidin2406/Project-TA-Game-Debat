using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    // Initialize variabel for level unlock system
    int levelsUnlocked;

    // Initialize array of buttons to unlock/locked
    public GameObject[] buttons;
    
    void Start()
    {
        // Default level Unlocked
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);

        // Disable/Locked the button
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(false);
        }

        // Enable/Unlocked the button
        for (int i = 0; i < levelsUnlocked; i++)
        {
            buttons[i].SetActive(true);
        }
    }
}
