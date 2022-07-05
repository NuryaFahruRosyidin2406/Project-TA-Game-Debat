using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahPS : MonoBehaviour
{
    public GameObject PanelMulai;
    public GameObject PanelHitungmundur;
    public GameObject Panelmg2S1;
    public GameObject SettingMenuSebelumMulai;
    public GameObject SettingMenuMulai;
    public GameObject ButtonSettingMenuSebelumMulai;
    public GameObject ButtonSettingMenuMulai;
    public GameObject HintMenu;
    public GameObject SoundOnMulai;
    public GameObject SoundOffMulai;
    public GameObject SoundOnBelumMulai;
    public GameObject SoundOffBelumMulai;
    public GameObject exitMenuMulai;
    public GameObject exitMenuSebelumMulai;
    public GameObject HintButtonMulai;
    public timersettings Timersettings;

    public void mgsoalsatuClicked()
    {
        Timersettings.mulaihm();
        ButtonSettingMenuMulai.SetActive(true);
        ButtonSettingMenuSebelumMulai.SetActive(false);
        HintButtonMulai.SetActive(true);
    }

    public void OpenKey(GameObject keyName)
    {
        keyName.SetActive(true);
    }

    public void CloseKey(GameObject keyName)
    {
        keyName.SetActive(false);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SettingMenuMulai.SetActive(false);
        SettingMenuSebelumMulai.SetActive(true);
    }

    public void OpenSettingMenuMulai()
    {
        SettingMenuMulai.SetActive(true);
    }

    public void CloseSettingMenuMulai()
    {
        SettingMenuMulai.SetActive(false);
    }

    public void OpenSettingMenuSebelumMulai()
    {
        SettingMenuSebelumMulai.SetActive(true);
    }

    public void CloseSettingMenuSebelumMulai()
    {
        SettingMenuSebelumMulai.SetActive(false);
    }

    public void OpenHintMenu()
    {
        HintMenu.SetActive(true);
    }

    public void CloseHintMenu()
    {
        HintMenu.SetActive(false);
    }

    public void OpenExitMenuMulai()
    {
        exitMenuMulai.SetActive(true);
    }

    public void ClosedExitMenuMulai()
    {
        exitMenuMulai.SetActive(false);
    }

    public void OpenExitMenuSebelumMulai()
    {
        exitMenuSebelumMulai.SetActive(true);
    }

    public void ClosedExitMenuSebelumMulai()
    {
        exitMenuSebelumMulai.SetActive(false);
    }

    public void TurnOnSoundMulai()
    {
        SoundOnMulai.SetActive(true);
        SoundOffMulai.SetActive(false);
    }

    public void TurnOffSoundMulai()
    {
        SoundOnMulai.SetActive(false);
        SoundOffMulai.SetActive(true);
    }

    public void TurnOnSoundBelumMulai()
    {
        SoundOnBelumMulai.SetActive(true);
        SoundOffBelumMulai.SetActive(false);
    }

    public void TurnOffSoundBelumMulai()
    {
        SoundOnBelumMulai.SetActive(false);
        SoundOffBelumMulai.SetActive(true);
    }
}
