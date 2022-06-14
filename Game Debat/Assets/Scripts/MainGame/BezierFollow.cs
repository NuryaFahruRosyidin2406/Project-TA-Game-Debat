using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BezierFollow : MonoBehaviour
{
    ScriptReader scriptReader;
    ScriptReaderLevelTwo scriptReaderLevelTwo;

    [SerializeField] GameObject dialogueManager;
    [SerializeField] private Transform[] routes;

    private int routeToGo;
    private float tParam;
    private Image buttonImage;
    private Vector2 objectPosition;

    [SerializeField] public float speedModifier;

    private Vector3 scaleChange;

    private bool coroutineAllowed;
    public string popUp;
    private bool showArgue;
    private int transitionNumber;
    public float displayChoiceTime;

    void Awake()
    {
        scriptReader = dialogueManager.GetComponent<ScriptReader>();
        if(scriptReader == null)
        {
            scriptReaderLevelTwo = dialogueManager.GetComponent<ScriptReaderLevelTwo>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        routeToGo = 0;
        tParam = 0f;
        speedModifier = Random.Range(0.2f, 1.5f);
        coroutineAllowed = true;
        buttonImage = GetComponent<Image>();
        transform.localScale = new Vector3(0f, 0f, 0f);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (scriptReader == null)
        {
            showArgue = scriptReaderLevelTwo.argumenShow;
            transitionNumber = scriptReaderLevelTwo.transitionNumber;
        }
        else
        {
            showArgue = scriptReader.argumenShow;
            transitionNumber = scriptReader.transitionNumber;
        }
        

        if (coroutineAllowed)
        {
            StartCoroutine(GoByTheRoute(routeToGo));
        }

        if (showArgue == true)
        {
            //buttonImage.enabled = true;
            if(transform.localScale.x < 1f && transform.localScale.y < 1f && transform.lossyScale.z < 1f)
            {
                transform.localScale += scaleChange = new Vector3(0.01f, 0.01f, 0.01f); ;
            }
            else
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            
            speedModifier = 0;
        }
        else if (showArgue == false)
        {
            //buttonImage.enabled = false;
            if (transform.localScale.x > 0f && transform.localScale.y > 0f && transform.lossyScale.z > 0f)
            {
                transform.localScale -= scaleChange = new Vector3(1f, 1f, 1f); ;
            }
            else
            {
                transform.localScale = new Vector3(0f, 0f, 0f);
            }

            if (speedModifier <= 0)
            {
                speedModifier = Random.Range(0.2f, 1.5f);
            }
            
        }
    }

    public void PopUpArgue()
    {
        PopUpSystem pop = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<PopUpSystem>();
        pop.PopUp(popUp);

        if (transitionNumber == 1)
        {
            
            if(scriptReader == null)
            {
                scriptReaderLevelTwo.nextScript("2_Transisi1");
            }
            else
            {
                scriptReader.nextScript("1_Transisi1");
            }
        }
        else if (transitionNumber == 2)
        {
            
            if (scriptReader == null)
            {
                scriptReaderLevelTwo.nextScript("2_Transisi2");
            }
            else
            {
                scriptReader.nextScript("1_Transisi2");
            }

        }
        else if (transitionNumber == 3)
        {
            
            if (scriptReader == null)
            {
                scriptReaderLevelTwo.nextScript("2_Transisi3");
            }
            else
            {
                scriptReader.nextScript("1_Transisi3");
            }
        }
    }

    private IEnumerator GoByTheRoute(int routeNum)
    {
        coroutineAllowed = false;

        Vector2 p0 = routes[routeNum].GetChild(0).position;
        Vector2 p1 = routes[routeNum].GetChild(1).position;
        Vector2 p2 = routes[routeNum].GetChild(2).position;
        Vector2 p3 = routes[routeNum].GetChild(3).position;

        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedModifier;

            objectPosition = Mathf.Pow(1 - tParam, 3) * p0 + 3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 + 3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 + Mathf.Pow(tParam, 3) * p3;

            transform.position = objectPosition;
            yield return new WaitForEndOfFrame();
        }

        tParam = 0f;

        routeToGo += 1;

        if (routeToGo > routes.Length - 1)
        {
            routeToGo = 0;
        }

        coroutineAllowed = true;

    }
}
