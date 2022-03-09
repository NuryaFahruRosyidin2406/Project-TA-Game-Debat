using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject circlePrefab;


    public int duplicate;
    void Start()
    {
        RandomSpawn();
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
            RandomSpawn();
        }
    }

    public void RandomSpawn()
    {
        Vector2 randomSpawnPosition = new Vector2(Random.Range(-2, 2), Random.Range(-2, 2));
        Instantiate(circlePrefab, randomSpawnPosition, Quaternion.identity);
    }
}
