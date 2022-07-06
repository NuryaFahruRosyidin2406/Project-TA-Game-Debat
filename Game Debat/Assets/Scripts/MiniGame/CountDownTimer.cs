using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{

    public GameData currentGameData;
    public Text timerText;

    private float _timeLeft;
    private float _minutes;
    private float _seconds;
    private float _oneSecondDown;
    private bool _timeOut;
    private bool _stopTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        _stopTimer = false;
        _timeOut = false;
        _timeLeft = currentGameData.selectedBoardData.timeInSecods;
        _oneSecondDown = _timeLeft - 1f;

        GameEvents.OnBoardCompleted += StopTimer;
    }

    private void OnDisable()
    {
        GameEvents.OnBoardCompleted -= StopTimer;
    }

    public void StopTimer()
    {
        _stopTimer = true;
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "TutorialMiniGame")
        {
            // Time is not running down
        }
        else
        {
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

    private void ActivateGameOverGUI()
    {
        GameEvents.GameOverMethod();
        _timeOut = true;
    }
}
