using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayLST : MonoBehaviour
{
    public Text scorelevelsatu;
    public Text highscorelevelsatu;

    // Start is called before the first frame update
    void Start()
    {
        scorelevelsatu.text = PlayerPrefs.GetInt("Scoremg2").ToString();
        highscorelevelsatu.text = PlayerPrefs.GetInt("HighScoremg2", 0).ToString();
    }
}
