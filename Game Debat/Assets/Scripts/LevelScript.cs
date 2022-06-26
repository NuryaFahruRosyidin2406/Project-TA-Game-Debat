using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    public void Pass()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
        {
            PlayerPrefs.SetInt("levelsUnlocked", currentLevel + 1);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelsUnlocked") + " UNLOCKED");
    }

    public void TurtorialPass()
    {
        if (PlayerPrefs.GetInt("levelsUnlocked") < 2)
        {
            PlayerPrefs.SetInt("levelsUnlocked", 2);
            Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelsUnlocked") + " UNLOCKED");
        }
        else
            Debug.Log("Tutorial sudah pernah di selesaikan");
    }
}
