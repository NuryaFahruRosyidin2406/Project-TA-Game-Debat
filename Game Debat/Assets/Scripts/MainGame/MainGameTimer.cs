using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameTimer : MonoBehaviour
{
    ScriptReader scriptReader;
    [SerializeField] GameObject dialogueManager;

    public Text timerText;

    public float _startTime;

    private float _timeLeft;
    private float _minutes;
    private float _seconds;
    private float _oneSecondDown;
    private bool _timeOut;
    private bool _stopTimer;

    private bool _debateStatus;

    void Awake()
    {
        scriptReader = dialogueManager.GetComponent<ScriptReader>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _stopTimer = true;
        _timeOut = false;
        _timeLeft = _startTime;
        _debateStatus = scriptReader.debateRun;

        _oneSecondDown = _timeLeft - 1f;
    }

    void Update()
    {
        _debateStatus = scriptReader.debateRun;
        if (_debateStatus)
        {
            _stopTimer = false;
            if (_stopTimer == false)
            {
                _timeLeft -= Time.deltaTime;
            }

            if (_timeLeft <= _oneSecondDown)
            {
                _oneSecondDown = _timeLeft - 1f;
            }
        }
        else
        {
            _timeLeft = _startTime;
        }
    }

    void OnGUI()
    {
        if (_timeOut == false)
        {
            if (_timeLeft > 0)
            {
                _minutes = Mathf.Floor(_timeLeft / 60);
                _seconds = Mathf.RoundToInt(_timeLeft % 60);

                timerText.text = _minutes.ToString("00") + ":" + _seconds.ToString("00");
            }
            else
            {
                dialogueManager.GetComponent<ScriptReader>().nextScript("3_TimesUp"); // change Script to TimesUp
                dialogueManager.GetComponent<ScriptReader>().RefreshChoiceView(); // Delete choice when times up
                _debateStatus = false;
                _stopTimer = true;
                _timeOut = true;
            }
        }
    }
}
