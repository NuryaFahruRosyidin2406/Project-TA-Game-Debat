using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class ScriptReader : MonoBehaviour
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

    public float TimeLeft = 4;
    public bool TimerOn = false;

    
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
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Chat Time is up!");
                DisplayNextLine();
                //TimeLeft = 3; // use this if you want to change all the time for the dialogue
                
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
        _StoryScript.BindExternalFunction("ShowArgue", (int argueStatus) => showArgue(argueStatus));
        _StoryScript.BindExternalFunction("ChangeTime", (float timeLeft) => changeTime(timeLeft)); // Change time for the dialogue
        _StoryScript.BindExternalFunction("ChangeScript", (string scriptName) => nextScript(scriptName));
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
        _StoryScript.ChooseChoiceIndex(choice.index);
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

    public void showArgue(int argumen)
    {
        int argumenNumber = argumen;
        Debug.Log(argumenNumber);
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

    void updateTimer(float currentTime) // update dialogue timer
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
    }
}

