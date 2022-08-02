using System.Collections; //Library untuk menggunakan fungsi dasar C#
using System.Collections.Generic;
using UnityEngine; //Library untuk menggunakan fungsi dasar unity
using UnityEngine.UI; //Library untuk menggunakan fungsi dasar UI unity
using Ink.Runtime; //Library untuk menggunakan fungsi inky pada unity
using TMPro; //Library untuk menggunakan TMP pada unity
using UnityEngine.SceneManagement; //Library untuk menggunakan fungsi Management Scene

public class ScriptReader : MonoBehaviour 
{
    LevelScript levelScript; //Untuk mengakses fungsi dan variabel dari level script
    ScoreFuzzy scoreFuzzy;
    ScoreDisplay scoreDisplay;

    //Menginialisasikan variabel sehingga dapat direferensikan di unity inspector
    [SerializeField] GameObject dialogueManager;

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
    public float choiceTimerSubtract = 0f;

    public bool debateRun;
    public bool launchFuzzy;
    public bool scoreShow;
    public int debateScoreIsi, debateScorePenyampaian, debateScoreStrategi, statusHighscoreFuzzy;

    public bool argumenShow;
    public int transitionNumber;

    void Awake() //fungsi akan dipanggil ketika game dijalankan
    {
        levelScript = dialogueManager.GetComponent<LevelScript>();
        scoreFuzzy = dialogueManager.GetComponent<ScoreFuzzy>();
    }

    void Start() //fungsi akan dipanggil ketika frame pertama (masuk dlm scene) dijalankan
    {
        TimerOn = true; //menyalakan timer dialogue
        LoadStory(); //load file inky
    }

    void Update() //fungsi dipanggil setiap frame berjalan
    {
        if (TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
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

    void LoadStory() //fungsi untuk membuka cerita selanjutnya (script inky)
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
        _StoryScript.BindExternalFunction("DebateStatus", (bool debateStatus) => doingDebate(debateStatus)); // Change debate status
        _StoryScript.BindExternalFunction("AddDebateScoreIsi", (int debateScoreIsi) => addDebateScoreIsi(debateScoreIsi)); // Add or Reduce Player Score Isi
        _StoryScript.BindExternalFunction("AddDebateScorePenyampaian", (int debateScorePenyampaian) => addDebateScorePenyampaian(debateScorePenyampaian)); // Add or Reduce Player Score Isi
        _StoryScript.BindExternalFunction("AddDebateScoreStrategi", (int debateScoreStrategi) => addDebateScoreStrategi(debateScoreStrategi)); // Add or Reduce Player Score Strategi
        _StoryScript.BindExternalFunction("CalculateScoreFuzzy", (bool fuzzyStatus) => calculateScoreFuzzy(fuzzyStatus)); // Change status to calculate fuzzy
        _StoryScript.BindExternalFunction("ShowScore", (bool scoreStatus) => showScore(scoreStatus)); // Change status of showing the score
        _StoryScript.BindExternalFunction("HighscoreStatus", (int statusHighscore) => highscoreStatus(statusHighscore)); // Change status of showing the score
        _StoryScript.BindExternalFunction("ChoiceTime", (float timeLeft) => choiceTime(timeLeft));
        _StoryScript.BindExternalFunction("ChangeChoiceTime", (float changeTime) => subChoiceTime(changeTime)); //Mengubah waktu untuk memilih
        _StoryScript.BindExternalFunction("ChangeScript", (string scriptName) => nextScript(scriptName));
        _StoryScript.BindExternalFunction("ChangeScene", (string sceneName) => changeScene(sceneName)); // Change scene into a new scene
        _StoryScript.BindExternalFunction("PassLevel", (bool status) => PassLevel(status)); // Unlock next level
        _StoryScript.BindExternalFunction("TutorialPass", (bool status) => TutorialPass(status)); // Pass Tutorial Level
        _StoryScript.BindExternalFunction("SoundEffect", (string soundName) => PlaySoundEffect(soundName)); // Add Sound effect in Inky
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
        //choiceTimer = 5f;
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

    public void RefreshChoiceView()
    {
        if(choiceHolder != null)
        {
            foreach(var button in choiceHolder.GetComponentsInChildren<Button>())
            {
                Destroy(button.gameObject);
            }
        }
    }

    public void PassLevel(bool status)
    {
        if (status)
        {
            levelScript.Pass();
            status = false;
        }
    }

    public void TutorialPass(bool status)
    {
        if (status)
        {
            levelScript.TurtorialPass();
            status = false;
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

    public void doingDebate(bool status)
    {
        debateRun = status;
        Debug.Log("Debate Status " + debateRun);
    }

    public void showScore(bool status)
    {
        scoreShow = status;
        Debug.Log("Score Ditampilan: " + scoreShow);
    }

    public void calculateScoreFuzzy(bool statusfuzzy)
    {
        launchFuzzy = statusfuzzy;
        Debug.Log("Score Ditampilan: " + launchFuzzy);
        if (launchFuzzy)
        {
            Debug.Log("1. Mulai masuk perhitungan fuzzy: " + launchFuzzy);
            scoreFuzzy.metodeFuzzyMamdani();
        }
        else Debug.Log("2. Mulai masuk perhitungan fuzzy: " + launchFuzzy);
    }

    public void highscoreStatus(int addhighscoreStatus)
    {
        statusHighscoreFuzzy = addhighscoreStatus;
        Debug.Log("Score Ditampilan: " + statusHighscoreFuzzy);
        if (statusHighscoreFuzzy == 1)
        {
            Debug.Log("1. Mulai masuk memasukkan highscore fuzzy level satu: " + statusHighscoreFuzzy);
            scoreFuzzy.highscoreLevelOne();
        }
        else if (statusHighscoreFuzzy == 2) 
        {
            Debug.Log("1. Mulai masuk memasukkan highscore fuzzy level dua: " + statusHighscoreFuzzy);
            scoreFuzzy.highscoreLevelTwo();
        }
    }

    public void addDebateScoreIsi(int scoreIsi) // Add Player Score Isi
    {
        debateScoreIsi += scoreIsi;
        Debug.Log("Score isi pemain saat ini " + debateScoreIsi);
        PlayerPrefs.SetInt("debateSkorIsi", debateScoreIsi);
    }

    public void addDebateScorePenyampaian(int scorePenyampaian) // Add Player Score Penyampaian
    {
        debateScorePenyampaian += scorePenyampaian;
        Debug.Log("Score penyampaian pemain saat ini " + debateScorePenyampaian);
        PlayerPrefs.SetInt("debateSkorPenyampaian", debateScorePenyampaian);
    }

    public void addDebateScoreStrategi(int scoreStrategi) // Add Player Score Strategi
    {
        debateScoreStrategi += scoreStrategi;
        Debug.Log("Score strategi pemain saat ini " + debateScoreStrategi);
        PlayerPrefs.SetInt("debateSkorStrategi", debateScoreStrategi);
    }

    public void changeTime(float time) // function to change time in the inky
    {
        float setTimeLeft = time;
        TimeLeft = setTimeLeft;
        Debug.Log(TimeLeft + " Seconds");
    }

    public void choiceTime(float time) // function to change choice time in the inky
    {
        choiceTimer = time;
        choiceTimer += choiceTimerSubtract;
        Debug.Log(choiceTimer + " Seconds");
    }

    public void subChoiceTime(float time)
    {
        choiceTimerSubtract += time;
        Debug.Log("Choice Time add by "+ choiceTimerSubtract + " Seconds");
    }

    public void nextScript(string name) // Load Next Script for the dialogue
    {
        if (SceneManager.GetActiveScene().name == "LevelOne")
        {
            var loadScript = Resources.Load<TextAsset>("InkScripts/LevelOne/" + name);
            Debug.Log(loadScript);
            _inkJsonFile = loadScript;
        }
        else if (SceneManager.GetActiveScene().name == "LevelTwo")
        {
            var loadScript = Resources.Load<TextAsset>("InkScripts/LevelTwo/" + name);
            Debug.Log(loadScript);
            _inkJsonFile = loadScript;
        }
        else if (SceneManager.GetActiveScene().name == "IntroScene")
        {
            var loadScript = Resources.Load<TextAsset>("InkScripts/IntroScene/" + name);
            Debug.Log(loadScript);
            _inkJsonFile = loadScript;
        }
        else if (SceneManager.GetActiveScene().name == "TutorialMiniGame")
        {
            var loadScript = Resources.Load<TextAsset>("InkScripts/TutorialMiniGame/" + name);
            Debug.Log(loadScript);
            _inkJsonFile = loadScript;
        }
        else if (SceneManager.GetActiveScene().name == "TutorialMainGame")
        {
            var loadScript = Resources.Load<TextAsset>("InkScripts/TutorialMainGame/" + name);
            Debug.Log(loadScript);
            _inkJsonFile = loadScript;
        }

        LoadStory();
    }

    public void changeScene(string sceneName)
    {
        Debug.Log("Change scene into " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void PlaySoundEffect(string soundName) // Add sound effect function
    {
        SoundManagerScript.PlaySound(soundName);
        Debug.Log("Play sound effect " + soundName);
    }
}

