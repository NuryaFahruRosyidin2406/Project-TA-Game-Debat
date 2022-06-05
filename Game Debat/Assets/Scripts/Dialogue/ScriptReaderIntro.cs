using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;
using UnityEngine.SceneManagement;

public class ScriptReaderIntro : MonoBehaviour
{
    [SerializeField]
    public TextAsset _inkJsonFile;
    public Story _StoryScript;

    public TMP_Text dialogueBox;
    public TMP_Text nameTag;

    public Image characterIcon;

    [SerializeField]
    private GridLayoutGroup choiceHolder;

    [SerializeField]
    private Button choiceBasePrefab;

    public float TimeLeft = 4f;
    public bool TimerOn = false;

    public bool onChoice = false;
    public float choiceTimer = 4f;

    public bool argumenShow;
    public int transitionNumber;

    void Start()
    {
        TimerOn = true;
        LoadStory();
    }

    void Update()
    {
        if (TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                //updateTimer(TimeLeft);
            }
            else
            {
                DisplayNextLine();
                //TimeLeft = 3; // use this if you want to change all the time for the dialogue

            }
        }

        if (onChoice)
        {
            if(choiceTimer > 0)
            {
                choiceTimer -= Time.deltaTime;
            }
            else
            {
                DefaultOnClickChoiceButon(2);
                onChoice = false;
            }
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextLine();
        } 
    }

    void LoadStory()
    {
        _StoryScript = new Story(_inkJsonFile.text);

        _StoryScript.BindExternalFunction("Name", (string charName) => ChangeName(charName));
        _StoryScript.BindExternalFunction("Icon", (string charName) => CharacterIcon(charName));
        _StoryScript.BindExternalFunction("CharAnimation", (string charName, string animName) => playCharacterAnim(charName, animName));
        _StoryScript.BindExternalFunction("CharExpression", (string charName, int expressionInt) => changeCharacterExpression(charName, expressionInt));
        _StoryScript.BindExternalFunction("charTarget", (string charName, float moveSpeed, float xpos, float ypos, float zpos) => setCharacterMoveTarget(charName, moveSpeed, xpos, ypos, zpos)); //Change character position.        
        _StoryScript.BindExternalFunction("ShowArgue", (bool argueStatus) => showArgue(argueStatus));
        _StoryScript.BindExternalFunction("TransNum", (int transNumber) => transNum(transNumber));
        _StoryScript.BindExternalFunction("ChangeTime", (float timeLeft) => changeTime(timeLeft)); // Change time for the dialogue
        _StoryScript.BindExternalFunction("ChangeScript", (string scriptName) => nextScript(scriptName)); // Change script
        _StoryScript.BindExternalFunction("ChangeScene", (string sceneName) => changeScene(sceneName)); // Change scene into a new scene
        DisplayNextLine();
    }

    public void DisplayNextLine()
    {
        if (_StoryScript.canContinue) // Checking if there is content to go through
        {
            string text = _StoryScript.Continue(); // Gets Next Line
            text = text?.Trim(); // Removes White space from the text
            dialogueBox.text = text; // Display new text
        }
        else if (_StoryScript.currentChoices.Count > 0)
        {
            DisplayChoices();
        }
        else
        {
            dialogueBox.text = ". . . "; //display when there is no text.
            TimerOn = false;
        }
    }

    private void DisplayChoices()
    {    
        if (choiceHolder.GetComponentsInChildren<Button>().Length > 0) return; //checks if button holder has buttons in it.

        for(int i = 0; i < _StoryScript.currentChoices.Count; i++)
        {
            var choice = _StoryScript.currentChoices[i];
            var button = CreateChoiceButton(choice.text); //create a choice button

            button.onClick.AddListener(() => OnClickChoiceButon(choice));
        }

        onChoice = true;
        choiceTimer = 100f;
    }

    Button CreateChoiceButton(string text)
    {
        //Instantiate the button Prefab
        var choiceButton = Instantiate(choiceBasePrefab);
        choiceButton.transform.SetParent(choiceHolder.transform, false);

        //change the text in the button Prefab
        var buttonText = choiceButton.GetComponentInChildren<TMP_Text>();
        buttonText.text = text;

        return choiceButton;
    }

    void OnClickChoiceButon(Choice choice)
    {
        Debug.Log("pilihan " + choice.index);
        _StoryScript.ChooseChoiceIndex(choice.index);
        RefreshChoiceView();
        DisplayNextLine();
        onChoice = false;
    }

    void DefaultOnClickChoiceButon(int defaultChoice)
    {
        _StoryScript.ChooseChoiceIndex(defaultChoice);
        RefreshChoiceView();
        DisplayNextLine();
    }

    void RefreshChoiceView()
    {
        if(choiceHolder != null)
        {
            foreach(var button in choiceHolder.GetComponentsInChildren<Button>())
            {
                Destroy(button.gameObject);
            }
        }
    }

    public void ChangeName(string name)
    {
        string SpeakerName = name;

        nameTag.text = SpeakerName;
    }

    public void CharacterIcon(string name)
    {
        var charIcon = Resources.Load<Sprite>("Live2DModelsIcon/"+name);
        characterIcon.sprite = charIcon;
    }

    public void playCharacterAnim(string charName, string animName)
    {
        GameObject character = GameObject.Find(charName);
        
        Debug.Log("Changing " + character.name + "'s Animation to" + animName);

        character.GetComponent<CharAnim>().CharacterMotion(animName);
    }

    public void changeCharacterExpression(string charName, int expressionNumber)
    {
        GameObject character = GameObject.Find(charName);
        
        Debug.Log("Changing " + character.name + "'s Expression to" + expressionNumber );

        character.GetComponent<CharAnim>().CharacterExpression(expressionNumber);
    }

    public void setCharacterMoveTarget(string charName, float movingSpeed, float xpos, float ypos, float zpos)
    {
        GameObject character = GameObject.Find(charName);
        Vector3 targetPosition = new Vector3(xpos, ypos, zpos);
        
        Debug.Log("Moving " + character.name + "'s position to" + targetPosition);
        
        character.GetComponent<CharPosition>().setTarget(targetPosition, movingSpeed);
    }

    public void showArgue(bool argumen)
    {
        argumenShow = argumen;
        Debug.Log(argumenShow);
    }

    public void transNum(int number)
    {
        transitionNumber = number;
        Debug.Log("Transision number: " + transitionNumber);
    }

    public void changeTime(float time) // function to change time in the inky
    {
        float setTimeLeft = time;
        TimeLeft = setTimeLeft;
        Debug.Log(TimeLeft + " Seconds");
    }

    public void nextScript(string name) // Load Next Script for the dialogue
    {
        var loadScript = Resources.Load<TextAsset>("InkScripts/LevelOne/" + name);
        Debug.Log(loadScript);
        _inkJsonFile = loadScript;
        LoadStory();
    }

    public void changeScene(string sceneName)
    {
        Debug.Log("Change scene into " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    void updateTimer(float currentTime) // update dialogue timer
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
    }
}

