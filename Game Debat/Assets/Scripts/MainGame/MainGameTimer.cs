using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameTimer : MonoBehaviour
{
    // Acces scriptReader script function and variable
    ScriptReader scriptReader;

    // Initialize object to refrence in Unity Inspector
    [SerializeField] GameObject dialogueManager;

    // Initialize variabel for Main Game Timer
    public Text timerText;
    public float _startTime;
    private float _timeLeft, _minutes, _seconds;
    private bool _timeOut, _stopTimer, _debateStatus;

    // Awake is called right after the sistem start
    void Awake()
    {
        // Get ScriptReader component from dialogueManager
        scriptReader = dialogueManager.GetComponent<ScriptReader>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialize variable value
        _stopTimer = true;
        _timeOut = false;
        _timeLeft = _startTime;
        _debateStatus = scriptReader.debateRun;
    }

    // Update is called once per frame
    void Update()
    {
        // Get Debate status value from scriptReader
        _debateStatus = scriptReader.debateRun;
        
        // Branch for debate status to reduce the time
        if (_debateStatus)
        {
            _stopTimer = false;
            if (!_stopTimer)
            {
                // Reduce time base on real time second
                _timeLeft -= Time.deltaTime;
            }
        }
        else
        {
            // Reset back the time to it's initial value
            _timeLeft = _startTime;
        }
    }

    // Change the GUI for Main Game Timer
    void OnGUI()
    {
        // Do if there is still time in the 
        if (!_timeOut)
        {
            if (_timeLeft > 0)
            {
                // Change time format
                _minutes = Mathf.Floor(_timeLeft / 60);
                _seconds = Mathf.RoundToInt(_timeLeft % 60);

                // Change the text format in the Game
                timerText.text = _minutes.ToString("00") + ":" + _seconds.ToString("00");
            }
            else
            {
                // Change Script to TimesUp when the time is running out
                dialogueManager.GetComponent<ScriptReader>().nextScript("3_TimesUp");

                // Delete choice when times up
                dialogueManager.GetComponent<ScriptReader>().RefreshChoiceView(); 

                // Set new value for the variabel
                _debateStatus = false;
                _stopTimer = true;
                _timeOut = true;
            }
        }
    }
}
