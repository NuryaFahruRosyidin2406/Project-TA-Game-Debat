using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    int levelUnlocked;

    public Button[] buttons;
    
    void Start()
    {
        levelUnlocked = PlayerPrefs.GetInt("level");
    }

    void Update()
    {
        
    }
}
