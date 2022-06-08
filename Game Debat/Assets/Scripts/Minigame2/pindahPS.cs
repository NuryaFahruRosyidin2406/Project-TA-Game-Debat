using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahPS : MonoBehaviour
{
    public GameObject PanelMulai;
    public GameObject PanelHitungmundur;
    public GameObject Panelmg2S1;
    public timersettings Timersettings;

    public void mgsoalsatuClicked()
    {
        Timersettings.mulaihm();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
