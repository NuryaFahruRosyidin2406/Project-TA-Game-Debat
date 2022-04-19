using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPopup : MonoBehaviour
{
    public GameObject winPopup;
    public GameObject wordsPopup;

    void Start()
    {
        winPopup.SetActive(false);
    }

    private void OnEnable()
    {
        GameEvents.OnBoardCompleted += ShowWinPopup;
        GameEvents.OnBoardCompleted += ShowWordsPopup;
    }

    private void OnDisable()
    {
        GameEvents.OnBoardCompleted -= ShowWinPopup;
        GameEvents.OnBoardCompleted -= ShowWordsPopup;
    }

    private void ShowWinPopup()
    {
        winPopup.SetActive(true);
    }

    private void ShowWordsPopup()
    {
        wordsPopup.SetActive(false);
    }
}