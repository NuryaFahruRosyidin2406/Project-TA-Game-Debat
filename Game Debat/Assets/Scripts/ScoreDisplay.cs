using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    ScoreFuzzy scoreFuzzy;
    
    public Text highscoreLevelSatuText;
    public Text highscoreLevelDuaText;

    // Start is called before the first frame update
    void Start()
    {
        highscoreLevelSatuText.text = PlayerPrefs.GetInt("HighScoreLevelSatu", 0).ToString();
        highscoreLevelDuaText.text = PlayerPrefs.GetInt("HighScoreLevelDua", 0).ToString();
    }

    void Update()
    {
        highscoreLevelSatuText.text = PlayerPrefs.GetInt("HighScoreLevelSatu").ToString();
        highscoreLevelDuaText.text = PlayerPrefs.GetInt("HighScoreLevelDua").ToString();
    }

    public void hapusHighscoreSistem()
    {
        PlayerPrefs.DeleteKey("HighScoreLevelSatu");
        PlayerPrefs.DeleteKey("HighScoreLevelDua");
    }
}
