using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BezierFollow : MonoBehaviour
{
    ScriptReader scriptReader;

    [SerializeField] GameObject dialogueManager;
    [SerializeField] private Transform[] routes;

    private int routeToGo;
    private float tParam;
    private Image buttonImage;
    private Vector2 objectPosition;

    [SerializeField] public float speedModifier;
    
    private bool coroutineAllowed;
    public string popUp;
    private bool showArgue;
    private int transitionNumber;
    public float displayChoiceTime;

    void Awake()
    {
        scriptReader = dialogueManager.GetComponent<ScriptReader>();
    }

    // Start is called before the first frame update
    void Start()
    {
        routeToGo = 0;
        tParam = 0f;
        speedModifier = Random.Range(0.2f, 1.5f);
        coroutineAllowed = true;
        buttonImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        showArgue = scriptReader.argumenShow;
        transitionNumber = scriptReader.transitionNumber;

        if (coroutineAllowed)
        {
            StartCoroutine(GoByTheRoute(routeToGo));
        }

        if (showArgue == true)
        {
            buttonImage.enabled = true;
            speedModifier = 0;
        }
        else if (showArgue == false)
        {
            buttonImage.enabled = false;
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
            scriptReader.nextScript("1_Transisi1");
        }
        else if (transitionNumber == 2)
        {
            scriptReader.nextScript("2_Transisi2");
        }
        else if (transitionNumber == 3)
        {
            scriptReader.nextScript("3_Transisi3");
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
