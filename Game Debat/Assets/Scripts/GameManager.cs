using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject mainGameCanvas;
    public GameObject levelInfoCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    public void StartGame()
    {
        mainGameCanvas.SetActive(true);
        levelInfoCanvas.SetActive(false);
    }
}
