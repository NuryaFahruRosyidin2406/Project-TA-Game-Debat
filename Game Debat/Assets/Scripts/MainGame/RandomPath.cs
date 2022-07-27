using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPath : MonoBehaviour
{
    // Initialize variabel to get an object to refrence in Unity Inspector
    [SerializeField] GameObject routeSet;

    // Initialize variabel for the current route
    string currentRouteName;

    void Start()
    {
        // Get the current route name
        currentRouteName = gameObject.name;
    }

    // Deploy the Randomize position of all the route
    public void DeployRandomPath()
    {
        // Randomize the route position based on its name
        if (currentRouteName == "Route")
            RandomPositionPathA();
        else if (currentRouteName == "Route2")
            RandomPositionPathB();
        else if (currentRouteName == "Route3")
            RandomPositionPathC();
        else if (currentRouteName == "Route4")
            RandomPositionPathD();

    }

    // Set the randomize range for each route
    private void RandomPositionPathA()
    {
        gameObject.transform.localPosition = new Vector3(Random.Range(0, 450f), Random.Range(-295f, 245f), 0);
    }
    private void RandomPositionPathB()
    {
        gameObject.transform.localPosition = new Vector3(Random.Range(-460f, 0), Random.Range(0, 725f), 0);
    }
    private void RandomPositionPathC()
    {
        gameObject.transform.localPosition = new Vector3(Random.Range(-458f, 0), Random.Range(-316f, 345f), 0);
    }
    private void RandomPositionPathD()
    {
        gameObject.transform.localPosition = new Vector3(Random.Range(0, 450f), Random.Range(0, 725f), 0);
    }
}
