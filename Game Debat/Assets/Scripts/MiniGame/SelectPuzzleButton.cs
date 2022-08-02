using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectPuzzleButton : MonoBehaviour
{
    // Initialize variabel to get an object to refrence in Unity Inspector
    public GameData gameData;
    public GameLevelData levelData;
    public Text categoryText;

    // Initialize the game scene default value
    private string gameSceneName = "MiniGameScene";

    // run this when enter the scene
    void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
        button.interactable = true;
    }

    void Update()
    {

    }

    // load the game data and change to the mini game scene if the button is clicked
    private void OnButtonClick()
    {
        gameData.selectedCategoryName = gameObject.name;
        SceneManager.LoadScene(gameSceneName);
    }
}
