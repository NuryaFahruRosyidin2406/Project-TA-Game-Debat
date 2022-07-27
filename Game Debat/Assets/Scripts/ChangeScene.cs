using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Initialize variabel for Game Menu
    public GameObject settingMenu, highScoreMenu, creditMenu, 
        hintMenu, pauseMenu, exitMenu;

    // Initialize variabel for Key Word
    public GameObject keywordMenu, key1, key2, key3, key4, key5, key6;

    // Initialize variabel for Game Sound
    public GameObject soundOn, soundOff;

    // Initialize variabel for Pause System
    public GameObject pauseOn, pauseOff;

    // Resume the Game
    public void Resume()
    {
        // Closed the Pause Menu
        pauseMenu.SetActive(false);

        // Unfreeze the Game
        pauseOff.SetActive(true);
        pauseOn.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        // Open the Pause Menu
        pauseMenu.SetActive(true);

        // Freeze the Game
        pauseOff.SetActive(false);
        pauseOn.SetActive(true);
        Time.timeScale = 0f;
    }

    // Load any Scene based on its name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Closed the application
    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

    // Restarting the level/Scene
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Open Key Description
    public void OpenKey(GameObject keyName)
    {
        keyName.SetActive(true);
    }

    // Closed Key Description
    public void CloseKey(GameObject keyName)
    {
        keyName.SetActive(false);
    }

    // Open Key Menu
    public void OpenKeywordtMenu()
    {
        keywordMenu.SetActive(true);
    }

    // Closed Key Menu and Unfreeze the Game
    public void ClosedKeywordtMenu()
    {
        keywordMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    // Open Hint Menu
    public void OpenHintMenu()
    {
        hintMenu.SetActive(true);
    }

    // Closed the Hint Menu and Unfreeze the Game
    public void CloseHintMenu()
    {
        hintMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    // Open the Credit Menu
    public void OpenCreditMenu()
    {
        settingMenu.SetActive(false);
        creditMenu.SetActive(true);
    }

    // Closed the the Credit Menu
    public void CloseCreditMenu()
    {
        settingMenu.SetActive(true);
        creditMenu.SetActive(false);
    }

    // Open High Score Menu
    public void OpenHighScoreMenu()
    {
        highScoreMenu.SetActive(true);
    }

    // Closed the High Score Menu
    public void CloseHighScoreMenu()
    {
        highScoreMenu.SetActive(false);
    }

    // Open the Setting Menu
    public void OpenSettingMenu()
    {
        settingMenu.SetActive(true);
    }

    // Closed the Setting Menu
    public void CloseSettingMenu()
    {
        settingMenu.SetActive(false);
    }

    // Open the Exit Menu
    public void OpenExitMenu()
    {
        exitMenu.SetActive(true);
    }

    // Closed the Exit Menu
    public void ClosedExitMenu()
    {
        exitMenu.SetActive(false);
    }

    // Turn on the Game Sound
    public void TurnOnSound()
    {
        soundOn.SetActive(true);
        soundOff.SetActive(false);
    }

    // Turn off the Game Sound
    public void TurnOffSound()
    {
        soundOn.SetActive(false);
        soundOff.SetActive(true);
    }
}
