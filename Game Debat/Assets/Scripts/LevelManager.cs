using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    int levelsUnlocked;

    public GameObject[] buttons;
    
    void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(false);
        }

        for (int i = 0; i < levelsUnlocked; i++)
        {
            buttons[i].SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
