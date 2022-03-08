using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject circlePrefab;
    void Start()
    {
        RandomSpawn();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RandomSpawn();
        }
    }

    void RandomSpawn()
    {
        Vector2 randomSpawnPosition = new Vector2(Random.Range(-2, 2), Random.Range(-2, 2));
        Instantiate(circlePrefab, randomSpawnPosition, Quaternion.identity);
    }
}
