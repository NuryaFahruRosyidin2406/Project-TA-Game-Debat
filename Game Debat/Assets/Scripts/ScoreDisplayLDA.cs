using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayLDA : MonoBehaviour
{
    public Text scoreleveldua;
    public Text highscoreleveldua;

    // Start is called before the first frame update
    void Start()
    {
        /*scorelevelsatu.text = PlayerPrefs.GetInt("Scoremg2").ToString();
        highscorelevelsatu.text = PlayerPrefs.GetInt("HighScoremg2", 0).ToString();*/
        scoreleveldua.text = PlayerPrefs.GetInt("").ToString();
        highscoreleveldua.text = PlayerPrefs.GetInt("", 0).ToString();
    }
}
