using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    ScriptReader scriptReader;

    public GameObject displayMenu;
    [SerializeField] GameObject dialogueManager;

    public Text myScoreText;
    private int scoreNum;

    private bool showScore;
    public float timeToCountScore = 3f;

    void Awake()
    {
        scriptReader = dialogueManager.GetComponent<ScriptReader>();
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
            OpenMenu();
            if(timeToCountScore >= 0)
            {
                myScoreText.text = "" + Random.Range(0, 100);
                timeToCountScore -= Time.deltaTime;
            }
            else
            {
                myScoreText.text = "" + scoreNum;
            }
        }
        else
        {
            scoreNum = scriptReader.debateScore;
            showScore = scriptReader.scoreShow;
        }
    }

    public void OpenMenu()
    {
        displayMenu.SetActive(true);
    }
}
