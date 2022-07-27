using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    // Unlock the Next Level
    public void Pass()
    {
        // Get current active scene index
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        // Unlock the next level based on their index
        if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
        {
            PlayerPrefs.SetInt("levelsUnlocked", currentLevel + 1);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelsUnlocked") + " UNLOCKED");
    }

    // Pass the tutorial section
    public void TurtorialPass()
    {
        // Unlock the next level after the tutorial passed for the first time
        if (PlayerPrefs.GetInt("levelsUnlocked") < 2)
        {
            PlayerPrefs.SetInt("levelsUnlocked", 2);
            Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelsUnlocked") + " UNLOCKED");
        }
        else
            Debug.Log("Tutorial sudah pernah di selesaikan");
    }
}
