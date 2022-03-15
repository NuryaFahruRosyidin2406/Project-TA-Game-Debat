using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawner : MonoBehaviour
{
    public GameObject answerPrefab;
    public GameObject pointAPrefab;
    public GameObject pointBPrefab;
    public GameObject pointCPrefab;
    public GameObject pointDPrefab;
    public Text myScoreText;
    public int duplicate;
    public float spawnTime=1;

    private int scoreNum;

    void Start()
    {
        scoreNum = 0;
        myScoreText.text = "" + scoreNum;

        RandomSpawn();
        SpawnObject();
        duplicate = GameObject.FindGameObjectsWithTag("Answer").Length;

        Debug.Log(duplicate);
    }

    void Update()
    {
        duplicate = GameObject.FindGameObjectsWithTag("Answer").Length;
        if (Input.GetMouseButtonDown(0) && duplicate >= 1)
        {
            Debug.Log("Ada satu");
        }
        else if (duplicate == 0)
        {
            Debug.Log("Perlu di tambah");

            scoreNum += 1;
            myScoreText.text = "" + scoreNum;

            //Penyimpanan Score
            PlayerPrefs.SetInt("Score", scoreNum);
            if (scoreNum > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", scoreNum);
                //myHighScoreText.text = scoreNum.ToString();
            }
            //Penyimpanan Score

            Destroy(GameObject.FindGameObjectWithTag("PointA"));
            Destroy(GameObject.FindGameObjectWithTag("PointB"));
            Destroy(GameObject.FindGameObjectWithTag("PointC"));
            Destroy(GameObject.FindGameObjectWithTag("PointD"));
            RandomSpawn();
            if (spawnTime > 0)
            {
                spawnTime -= Time.deltaTime;
            }
            else if (spawnTime <= 0)
            {
                SpawnObject();
                spawnTime = 1;
            }
        }
    }

    public void RandomSpawn()
    {
        //Spawn Point A
        Vector2 randomSpawnPositionA = new Vector2(Random.Range(-4, -4), Random.Range(0, 5));
        Instantiate(pointAPrefab, randomSpawnPositionA, Quaternion.identity);

        //Spawn Point B
        Vector2 randomSpawnPositionB = new Vector2(Random.Range(0, 4), Random.Range(0, 5));
        Instantiate(pointBPrefab, randomSpawnPositionB, Quaternion.identity);

        //Spawn Point C
        Vector2 randomSpawnPositionC = new Vector2(Random.Range(-4, 0), Random.Range(-5, 0));
        Instantiate(pointCPrefab, randomSpawnPositionC, Quaternion.identity);

        //Spawn Point D
        Vector2 randomSpawnPositionD = new Vector2(Random.Range(4, 4), Random.Range(-5, 0));
        Instantiate(pointDPrefab, randomSpawnPositionD, Quaternion.identity);
    }

    public void SpawnObject()
    {
        //Spawn Answer
        Vector2 spawnAnswer = new Vector2(Random.Range(-8, -8), Random.Range(-8, -8));
        Instantiate(answerPrefab, spawnAnswer, Quaternion.identity);
    }
}
