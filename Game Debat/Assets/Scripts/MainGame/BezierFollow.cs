using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BezierFollow : MonoBehaviour
{
    // Acces scriptReader script function and variable
    ScriptReader scriptReader;

    // Initialize object to refrence in Unity Inspector
    [SerializeField] GameObject dialogueManager;
    [SerializeField] private Transform[] routes;

    // Initialize variabel for Bezier Route
    private int routeToGo;
    private float tParam;
    private Vector2 objectPosition;
    private bool coroutineAllowed;

    // Initialize variabel for interrupt button speed
    [SerializeField] public float speedModifier;

    // Initialize variabel for interrupt button size
    private Vector3 scaleChange;

    // Initialize variabel for Pop Up Anitmation and 
    public string popUp;
    private bool showArgue;
    private int transitionNumber;

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
        routeToGo = 0; // To start with the first set of path
        tParam = 0f;
        speedModifier = Random.Range(0.2f, 1.5f);
        coroutineAllowed = true;
        transform.localScale = new Vector3(0f, 0f, 0f);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Get variable value from scriptReader and assigned it to local variable
        showArgue = scriptReader.argumenShow;
        transitionNumber = scriptReader.transitionNumber;

        // Start the interrupt movement
        if (coroutineAllowed)
        {
            StartCoroutine(GoByTheRoute(routeToGo));
        }

        // Branch condition to show and stop the interrupt button
        if (showArgue)
        {
            // Enlarge the interrupt button size
            if (transform.localScale.x < 1f && transform.localScale.y < 1f && transform.lossyScale.z < 1f)
            {
                // Enlarge speed
                transform.localScale += scaleChange = new Vector3(0.01f, 0.01f, 0.01f); ;
            }
            else
            {
                // Set default size if Enlarge reach maximum value
                transform.localScale = new Vector3(1f, 1f, 1f);
            }

            // Value to stop interrupt button
            speedModifier = 0;
        }
        else if (!showArgue)
        {
            // Narrow the interrupt button size
            if (transform.localScale.x > 0f && transform.localScale.y > 0f && transform.lossyScale.z > 0f)
            {
                // Narrow Speed
                transform.localScale -= scaleChange = new Vector3(1f, 1f, 1f); ;
            }
            else
            {
                // Set default size if Narrow reach minimum value
                transform.localScale = new Vector3(0f, 0f, 0f);
            }

            // Set new speed movement for interrupt button
            if (speedModifier <= 0)
            {
                speedModifier = Random.Range(0.2f, 1.5f);
            }
            
        }

        // Pop up animation if NPC interrupt player argument
        if (transitionNumber == 4)
        {
            PopUpArgue();
        }

    }

    // Pop Up Animation & Sound Effect
    public void PopUpArgue()
    {
        // Load pop up animation and play sound effect 
        PopUpSystem pop = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<PopUpSystem>();
        pop.PopUp(popUp);
        SoundManagerScript.PlaySound("interupsi");

        // Branch Condition for ink script based on the transition number
        if (transitionNumber == 1) // Transition number 1 for argument 1
        {
            if (SceneManager.GetActiveScene().name == "LevelOne")
                scriptReader.nextScript("1_Transisi1"); // Load transition 1 for level 1
            else if(SceneManager.GetActiveScene().name == "LevelTwo")
                scriptReader.nextScript("2_Transisi1"); // Load transition 1 for level 2
        }
        else if (transitionNumber == 2) // Transition number 2 for argument 2
        {
            if (SceneManager.GetActiveScene().name == "LevelOne")
                scriptReader.nextScript("1_Transisi2"); // Load transition 2 for level 1
            else if (SceneManager.GetActiveScene().name == "LevelTwo")
                scriptReader.nextScript("2_Transisi2"); // Load transition 2 for level 2
        }
        else if (transitionNumber == 3) // Transition number 3 for argument 3
        {
            if (SceneManager.GetActiveScene().name == "LevelOne")
                scriptReader.nextScript("1_Transisi3"); // Load transition 3 for level 1
            else if (SceneManager.GetActiveScene().name == "LevelTwo")
                scriptReader.nextScript("2_Transisi3"); // Load transition 3 for level 2
        }
    }

    private IEnumerator GoByTheRoute(int routeNum)
    {
        // Disable coroutine when one is currently running
        coroutineAllowed = false;

        // Initialize start point of each node for the Bezier Curves path
        Vector2 p0 = routes[routeNum].GetChild(0).position;
        Vector2 p1 = routes[routeNum].GetChild(1).position;
        Vector2 p2 = routes[routeNum].GetChild(2).position;
        Vector2 p3 = routes[routeNum].GetChild(3).position;

        // If T is not yet reach 1 (end of Bezier track) calculate the position of the interrupt button
        while (tParam < 1)
        {
            // Increase T value base on Speed value on every second
            tParam += Time.deltaTime * speedModifier;

            // Calculated the new object position using bezier curves equation
            objectPosition = Mathf.Pow(1 - tParam, 3) * p0 + 3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 + 3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 + Mathf.Pow(tParam, 3) * p3;

            // Set the new position based on the position that have been counted with bezier curves equation
            transform.position = objectPosition;
            yield return new WaitForEndOfFrame();
        }

        // Set the T parameter to 0 (start of Bezier track)
        tParam = 0f;

        // Move to the next set of Bezier Curves path
        routeToGo += 1;

        // Reset routeToGo value back to 0 (Fist set of Bezier Curves Path)
        if (routeToGo > routes.Length - 1)
        {
            routeToGo = 0;
        }

        // Allow for new coroutine
        coroutineAllowed = true;
    }
}
