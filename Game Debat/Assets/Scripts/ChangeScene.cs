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
    public GameObject keywordMenu;
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;
    public GameObject key5;
    public GameObject key6;

    public GameObject soundOn;
    public GameObject soundOff;
    public GameObject pauseOn;
    public GameObject pauseOff;

    //public int nextSceneLoad;

    /*private void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;        
    }*/

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

    /*public void NextLevel()
    {
        SceneManager.LoadScene(nextSceneLoad);

        if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        }
    }*/

    public void OpenKey(GameObject keyName)
    {
        keyName.SetActive(true);
    }

    public void CloseKey(GameObject keyName)
    {
        keyName.SetActive(false);
    }

    public void OpenKeywordtMenu()
    {
        keywordMenu.SetActive(true);
        // Time.timeScale = 0f;
    }

    public void ClosedKeywordtMenu()
    {
        keywordMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OpenHintMenu()
    {
        hintMenu.SetActive(true);
    }

    public void CloseHintMenu()
    {
        hintMenu.SetActive(false);
        Time.timeScale = 1f;
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
