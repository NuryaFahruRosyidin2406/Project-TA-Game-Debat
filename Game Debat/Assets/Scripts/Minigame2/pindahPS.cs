using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahPS : MonoBehaviour
{
    public GameObject PanelMulai;
    public GameObject PanelHitungmundur;
    public GameObject Panelmg2S1;
    public GameObject SettingMenu;
    public GameObject HintMenu;
    public GameObject SoundOn;
    public GameObject SoundOff;
    public timersettings Timersettings;

    public void mgsoalsatuClicked()
    {
        Timersettings.mulaihm();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenSettingMenu()
    {
        SettingMenu.SetActive(true);
    }

    public void CloseSettingMenu()
    {
        SettingMenu.SetActive(false);
    }

    public void OpenHintMenu()
    {
        HintMenu.SetActive(true);
    }

    public void CloseHintMenu()
    {
        HintMenu.SetActive(false);
    }

    public void TurnOnSound()
    {
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
    }

    public void TurnOffSound()
    {
        SoundOn.SetActive(false);
        SoundOff.SetActive(true);
    }
}
