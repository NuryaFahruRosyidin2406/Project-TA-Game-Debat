using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class ScriptReader : MonoBehaviour
{
    [SerializeField]
    private TextAsset _inkJsonFile;
    private Story _StoryScript;

    public TMP_Text dialogueBox;
    public TMP_Text nameTag;

    public Image characterIcon;

    void Start()
    {
        LoadStory();
    }

    void Update()
    {
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
        else
        {
            dialogueBox.text = "That's all folks"; 
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
    
}
