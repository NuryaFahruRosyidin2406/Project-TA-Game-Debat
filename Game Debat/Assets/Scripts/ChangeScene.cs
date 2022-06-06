using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject soundOn;
    public GameObject soundOff;
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
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
