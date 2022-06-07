using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject highScoreMenu;
    public GameObject creditMenu;
    public GameObject hintMenu;
    public GameObject pauseMenu;

    public GameObject soundOn;
    public GameObject soundOff;
    public GameObject pauseOn;
    public GameObject pauseOff;

    
    public void Resume()
    {
        pauseMenu.SetActive(false);

        pauseOff.SetActive(true);
        pauseOn.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);

        pauseOff.SetActive(false);
        pauseOn.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenHintMenu()
    {
        hintMenu.SetActive(true);
    }

    public void CloseHintMenu()
    {
        hintMenu.SetActive(false);
    }

    public void OpenCreditMenu()
    {
        settingMenu.SetActive(false);
        creditMenu.SetActive(true);
    }

    public void CloseCreditMenu()
    {
        settingMenu.SetActive(true);
        creditMenu.SetActive(false);
    }

    public void OpenHighScoreMenu()
    {
        highScoreMenu.SetActive(true);
    }

    public void CloseHighScoreMenu()
    {
        highScoreMenu.SetActive(false);
    }

    public void OpenSettingMenu()
    {
        settingMenu.SetActive(true);
    }

    public void CloseSettingMenu()
    {
        settingMenu.SetActive(false);
    }

    public void TurnOnSound()
    {
        soundOn.SetActive(true);
        soundOff.SetActive(false);
    }

    public void TurnOffSound()
    {
        soundOn.SetActive(false);
        soundOff.SetActive(true);
    }
}
