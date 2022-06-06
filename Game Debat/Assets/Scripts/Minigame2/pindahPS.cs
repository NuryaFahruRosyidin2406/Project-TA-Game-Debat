using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pindahPS : MonoBehaviour
{
    public GameObject PanelMulai;
    public GameObject PanelHitungmundur;
    public GameObject Panelmg2S1;
    public timersettings Timersettings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void mgsoalsatuClicked()
    {
        Timersettings.mulaihm();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
