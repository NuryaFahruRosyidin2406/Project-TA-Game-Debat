using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreTime : MonoBehaviour
{
    private int time = 0;
    public Text timer;
    public Text timehighscore;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("TimeHighscore") == true)
        {
            timehighscore.text = PlayerPrefs.GetInt("TimeHighscore").ToString();
        }
        else
        {
            timehighscore.text = "No High Scores Yet";
        }
    }

    public void StartTimer()
    {
        time = 0;
        InvokeRepeating("IncrimentTime", 1, 1);
    }

    public void StopTimer()
    {
        CancelInvoke();
        if (PlayerPrefs.GetInt("TimeHighscore") < time)
        {
            SetTimeHighscore();
        }
    }

    public void SetTimeHighscore()
    {
        PlayerPrefs.SetInt("TimeHighscore", time);
        timehighscore.text = PlayerPrefs.GetInt("TimeHighscore").ToString();
    }

    public void ClearTimeHighscore()
    {
        PlayerPrefs.DeleteKey("TimeHighscore");
        timehighscore.text = "No High Scores Yet";
    }

    void IncrimentTime()
    {
        time += 1;
        //timer.text = "Time: " + time;
        timer.text = " " + time;
    }
}
