using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPopup : MonoBehaviour
{
    // Initialize variabel to get an object to refrence in Unity Inspector
    public GameObject gameOverPopup;  
    
    // Start is called before the first frame update
    void Start()
    {
        // set default game over value
        gameOverPopup.SetActive(false);

        GameEvents.OnGameOver += ShowGameOverPopup;
    }

    // if the game over pop up is disable run this
    private void OnDisable()
    {
        GameEvents.OnGameOver -= ShowGameOverPopup;
    }

    // Show the game over pop up
    private void ShowGameOverPopup()
    {
        gameOverPopup.SetActive(true);
    }
}
