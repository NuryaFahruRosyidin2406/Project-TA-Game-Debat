using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchingWord : MonoBehaviour
{
    // Initialize variabel for the searching word
    public Text displayedText;
    public Image crossLine;

    private string _word;
    void Start()
    {

    }

    // do this if the object is enable
    private void OnEnable()
    {
        GameEvents.OnCorrectWord += CorrectWord;
    }

    // do this if the object is disbale
    private void OnDisable()
    {
        GameEvents.OnCorrectWord -= CorrectWord;
    }

    // set the displayed text
    public void SetWord(string word)
    {
        _word = word;
        displayedText.text = word;
    }

    // cross the correct word
    private void CorrectWord(string word, List<int> squareIndexs)
    {
        if (word == _word)
        {
            crossLine.gameObject.SetActive(true);
        }
    }
}
