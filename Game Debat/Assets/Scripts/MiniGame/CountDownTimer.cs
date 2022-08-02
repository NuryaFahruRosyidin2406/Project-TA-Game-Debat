using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    // Initialize variabel to get the current game data
    public GameData currentGameData;
    public Text timerText;

    // Initialize variabel for count down system
    private float _timeLeft;
    private float _minutes;
    private float _seconds;
    private float _oneSecondDown;
    private bool _timeOut;
    private bool _stopTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        // Initialize the default value for each variabel
        _stopTimer = false;
        _timeOut = false;
        _timeLeft = currentGameData.selectedBoardData.timeInSecods;
        _oneSecondDown = _timeLeft - 1f;

        // change the value of stop timer
        GameEvents.OnBoardCompleted += StopTimer;
    }

    // if the object is disable the run this
    private void OnDisable()
    {
        GameEvents.OnBoardCompleted -= StopTimer;
    }

    // stop the timer
    public void StopTimer()
    {
        _stopTimer = true;
    }

    // run this every frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "TutorialMiniGame")
        {
            // Time is not running down
        }
        else
        {
            // reduce the time by 1 second every second
            if (_stopTimer == false)
            {
                _timeLeft -= Time.deltaTime;
            }

            if (_timeLeft <= _oneSecondDown)
            {
                _oneSecondDown = _timeLeft - 1f;
            }
        }
    }

    // Change the GUI format in the Game
    void OnGUI()
    {
        if(_timeOut == false)
        {
            if(_timeLeft > 0)
            {
                _minutes = Mathf.Floor(_timeLeft / 60);
                _seconds = Mathf.RoundToInt(_timeLeft % 60);

                timerText.text = _minutes.ToString("00") + ":" + _seconds.ToString("00");
            }
            else
            {
                _stopTimer = true;
                ActivateGameOverGUI();
            }
        }
    }

    // Activated the game over GUI
    private void ActivateGameOverGUI()
    {
        GameEvents.GameOverMethod();
        _timeOut = true;
    }
}
