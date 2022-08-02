using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPopup : MonoBehaviour
{
    // Initialize variabel to get an object to refrence in Unity Inspector
    public GameObject winPopup;
    public GameObject wordsPopup;

    // do this when enter the scene
    void Start()
    {
        winPopup.SetActive(false);
    }

    // do this when the object is enable
    private void OnEnable()
    {
        GameEvents.OnBoardCompleted += ShowWinPopup;
        GameEvents.OnBoardCompleted += ShowWordsPopup;
    }

    // do this if the object is disable
    private void OnDisable()
    {
        GameEvents.OnBoardCompleted -= ShowWinPopup;
        GameEvents.OnBoardCompleted -= ShowWordsPopup;
    }

    // show the win pop up
    private void ShowWinPopup()
    {
        winPopup.SetActive(true);
    }

    // show all the pop up words
    private void ShowWordsPopup()
    {
        wordsPopup.SetActive(false);
    }
}