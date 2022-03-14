using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text myScoreText;
    private int scoreNum;
    private int duplicate;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        myScoreText.text = "" + scoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        duplicate = GameObject.FindGameObjectsWithTag("Answer").Length;
        if (duplicate >= 1)
        {
            duplicate = GameObject.FindGameObjectsWithTag("Answer").Length;
            if (duplicate == 0)
            {
                scoreNum += 1;
            }
        }
    }
}
