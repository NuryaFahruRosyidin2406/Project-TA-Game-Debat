using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skordrag : MonoBehaviour
{
    public static int scoreValue = 0;
    public static Text score;

    public int scorevaluemg2 = 0;
    public int jmlscoremg2 = 0;
    int Scoremgdua;
    public Text scoremg2;
    public Text highscoremg2;
    public Text dsscoremg2;

    // Start is called before the first frame update
    void Start()
    {
        //score = GetComponent<Text>();
        dsscoremg2.text = PlayerPrefs.GetInt("Scoremg2").ToString();
        highscoremg2.text = PlayerPrefs.GetInt("HighScoremg2", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //score.text = scoreValue.ToString();
    }

    // dari line 23 sampai bawah ini Code score dan highscore untuk umum
    public void scoremgdua()
    {
        jmlscoremg2 += scorevaluemg2;
        Scoremgdua = jmlscoremg2;
        PlayerPrefs.SetInt("Scoremg2", Scoremgdua);
        scoremg2.text = jmlscoremg2.ToString();
        dsscoremg2.text = Scoremgdua.ToString();

        if (jmlscoremg2 > PlayerPrefs.GetInt("HighScoremg2", 0))
        {
            PlayerPrefs.SetInt("HighScoremg2", jmlscoremg2);
            highscoremg2.text = jmlscoremg2.ToString();
        }
    }

    public void resetscoremg2()
    {
        PlayerPrefs.DeleteKey("Scoremg2");
    }

    public void resetHighscore()
    {
        PlayerPrefs.DeleteKey("HighScoremg2");
    }

    // reset skor mg2 semua
    public void resetscoreallmg2()
    {
        PlayerPrefs.DeleteKey("Scoremg2");
        PlayerPrefs.DeleteKey("HighScoremg2");
    }
}
