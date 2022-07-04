using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    ScriptReader scriptReader;
    ScoreFuzzy scoreFuzzy;

    public GameObject displayMenu;
    [SerializeField] GameObject dialogueManager;

    public Text myScoreText;
    private int scoreNum;

    private bool showScore;
    public float timeToCountScore = 1f;

    void Awake()
    {
        scriptReader = dialogueManager.GetComponent<ScriptReader>();
        scoreFuzzy = dialogueManager.GetComponent<ScoreFuzzy>();
    }

    void Start()
    {
        scoreNum = 0;
        myScoreText.text = "" + scoreNum;
    }

    void Update()
    {
        if (showScore)
        {
            //scoreFuzzy.metodeFuzzyMamdani();
            OpenMenu();
            if (timeToCountScore >= 0)
            {
                SoundManagerScript.PlaySound("scorecount");
                myScoreText.text = "" + Random.Range(0, 100);
                timeToCountScore -= Time.deltaTime;
            }
            else
            {
                SoundManagerScript.StopSound();
                myScoreText.text = "" + scoreNum;
            }
        }
        else
        {
            scoreNum = (int) scoreFuzzy.hasilkeluaran;
            //scoreNum = scriptReader.debateScoreIsi;
            showScore = scriptReader.scoreShow;
            // Edit skor disini
        }
    }

    public void OpenMenu()
    {
        displayMenu.SetActive(true);
        // codingan ganti scene yang spesifik
        /*
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene("AkumulasiPointLDA");
        } 
        */
    }
}
