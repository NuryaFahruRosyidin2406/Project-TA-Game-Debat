using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArgueSpawner : MonoBehaviour
{
    public GameObject answerPrefab;
    public GameObject pointAPrefab;
    public GameObject pointBPrefab;
    public GameObject pointCPrefab;
    public GameObject pointDPrefab;

    void Start()
    {
        RandomSpawn();
        SpawnObject();
    }

    void Update()
    {
        
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
