using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timersettings : MonoBehaviour
{
    public int countdownTime;
    public int cdTimereturn;
    public float Waktu = 100;
    public float counterWaktu = 100;
    float s;
    public bool GameAktif = false;
    public GameObject PanelMulai;
    public GameObject PanelHitungmundur;
    public GameObject PanelWadahUI;
    public GameObject Panelmg2S1;
    public GameObject PanelSelesaimg2;
    public Text countdownDisplay;
    public Text TextTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    public void counterwaktu()
    {
        if (Waktu == 0)
        {
            Waktu = counterWaktu;
        }
    }

    public void waktuberhenti()
    {
        GameAktif = false;
        TextTimer.gameObject.SetActive(false);
        //skordrag.score.gameObject.SetActive(false);
        //countdownDisplay.gameObject.SetActive(false);
        Waktu = 0;
    }

    public void mulaihm()
    {
        PanelMulai.SetActive(false);
        PanelHitungmundur.SetActive(true);
        PanelWadahUI.SetActive(true);
        Panelmg2S1.SetActive(true);
        StartCoroutine(CountdownToStart());
    }

    // Waktu hitung mundur
    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownDisplay.text = "Mulai!";
        yield return new WaitForSeconds(1f);
        //countdownDisplay.gameObject.SetActive(false);
        PanelHitungmundur.SetActive(false);
        Panelmg2S1.SetActive(true);
        GameAktif = true;

        // Mengembalikan nilai Countdown Time
        if (countdownTime == 0)
        {
            countdownTime = cdTimereturn;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (GameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }
        if (GameAktif && Waktu <= 0)
        {
            PanelSelesaimg2.SetActive(true);
            waktuberhenti();
        }
        SetText();
    }
}
