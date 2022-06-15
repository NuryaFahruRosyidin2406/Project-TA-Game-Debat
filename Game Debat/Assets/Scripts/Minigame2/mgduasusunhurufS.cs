using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mgduasusunhurufS : MonoBehaviour
{
    public GameObject lettreOne, lettreTwo, lettreThree, lettreFour, lettreFive, lettreSix, lettreSeven, lettreEight, lettreNine, BoxOne, BoxTwo, BoxThree, BoxFour, BoxFive, BoxSix, BoxSeven, BoxEight, BoxNine;

    Vector3 lettreOneIni, lettreTwoIni, lettreThreeIni, lettreFourIni, lettreFiveIni, lettreSixIni, lettreSevenIni, lettreEightIni, lettreNineIni;

    string str = "";
    public string word, word2, word3, word4;
    public string Kataditemukan, Kataditemukan1, Kataditemukan2, Kataditemukan3, Kataditemukan4, Kataditemukan5, Kataditemukan6;

    public Text KatadiTemukan;

    public GameObject questionToHide, questionToShow;

    bool oneCorrect, twoCorrect, threeCorrect, fourCorrect, fiveCorrect, sixCorrect, sevenCorrect, eightCorrect, nineCorrect = false;

    Vector3 iniScaleLettreOne, iniScaleLettreTwo, iniScaleLettreThree, iniScaleLettreFour, iniScaleLettreFive, iniScaleLettreSix, iniScaleLettreSeven, iniScaleLettreEight, iniScaleLettreNine;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    public AudioClip reload;
    public AudioClip buttonDrop;

    public timersettings Timersettings;
    public skordrag Skordrag;

    // Start is called before the first frame update
    void Start()
    {
        lettreOneIni = lettreOne.transform.position;
        lettreTwoIni = lettreTwo.transform.position;
        lettreThreeIni = lettreThree.transform.position;
        lettreFourIni = lettreFour.transform.position;
        lettreFiveIni = lettreFive.transform.position;
        lettreSixIni = lettreSix.transform.position;
        lettreSevenIni = lettreSeven.transform.position;
        lettreEightIni = lettreEight.transform.position;
        lettreNineIni = lettreNine.transform.position;

        iniScaleLettreOne = lettreOne.transform.localScale;
        iniScaleLettreTwo = lettreTwo.transform.localScale;
        iniScaleLettreThree = lettreThree.transform.localScale;
        iniScaleLettreFour = lettreFour.transform.localScale;
        iniScaleLettreFive = lettreFive.transform.localScale;
        iniScaleLettreSix = lettreSix.transform.localScale;
        iniScaleLettreSeven = lettreSeven.transform.localScale;
        iniScaleLettreEight = lettreEight.transform.localScale;
        iniScaleLettreNine = lettreNine.transform.localScale;
    }

    public void DragLettreOne()
    {
        lettreOne.transform.position = Input.mousePosition;
    }

    public void DragLettreTwo()
    {
        lettreTwo.transform.position = Input.mousePosition;
    }

    public void DragLettreThree()
    {
        lettreThree.transform.position = Input.mousePosition;
    }

    public void DragLettreFour()
    {
        lettreFour.transform.position = Input.mousePosition;
    }

    public void DragLettreFive()
    {
        lettreFive.transform.position = Input.mousePosition;
    }

    public void DragLettreSix()
    {
        lettreSix.transform.position = Input.mousePosition;
    }

    public void DragLettreSeven()
    {
        lettreSeven.transform.position = Input.mousePosition;
    }

    public void DragLettreEight()
    {
        lettreEight.transform.position = Input.mousePosition;
    }

    public void DragLettreNine()
    {
        lettreNine.transform.position = Input.mousePosition;
    }

    //dragdrop1
    public void DropLettreOne()
    {
        float Distance = Vector3.Distance(lettreOne.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreOne.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreOne.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreOne.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreOne.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreOne.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreOne.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreOne.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreOne.transform.position, BoxNine.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreOne.transform.localScale = BoxOne.transform.localScale;
            lettreOne.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreOne.transform.localScale = BoxTwo.transform.localScale;
            lettreOne.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreOne.transform.localScale = BoxThree.transform.localScale;
            lettreOne.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreOne.transform.localScale = BoxFour.transform.localScale;
            lettreOne.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreOne.transform.localScale = BoxFive.transform.localScale;
            lettreOne.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreOne.transform.localScale = BoxSix.transform.localScale;
            lettreOne.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreOne.transform.localScale = BoxSeven.transform.localScale;
            lettreOne.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreOne.transform.localScale = BoxEight.transform.localScale;
            lettreOne.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreOne.transform.localScale = BoxNine.transform.localScale;
            lettreOne.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreOne.transform.position = lettreOneIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop2
    public void DropLettreTwo()
    {
        float Distance = Vector3.Distance(lettreTwo.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreTwo.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreTwo.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreTwo.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreTwo.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreTwo.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreTwo.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreTwo.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreTwo.transform.position, BoxNine.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreTwo.transform.localScale = BoxOne.transform.localScale;
            lettreTwo.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreTwo.transform.localScale = BoxTwo.transform.localScale;
            lettreTwo.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreTwo.transform.localScale = BoxThree.transform.localScale;
            lettreTwo.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreTwo.transform.localScale = BoxFour.transform.localScale;
            lettreTwo.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreTwo.transform.localScale = BoxFive.transform.localScale;
            lettreTwo.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreTwo.transform.localScale = BoxSix.transform.localScale;
            lettreTwo.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreTwo.transform.localScale = BoxSeven.transform.localScale;
            lettreTwo.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreTwo.transform.localScale = BoxEight.transform.localScale;
            lettreTwo.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreTwo.transform.localScale = BoxNine.transform.localScale;
            lettreTwo.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreTwo.transform.position = lettreTwoIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop3
    public void DropLettreThree()
    {
        float Distance = Vector3.Distance(lettreThree.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreThree.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreThree.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreThree.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreThree.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreThree.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreThree.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreThree.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreThree.transform.position, BoxNine.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreThree.transform.localScale = BoxOne.transform.localScale;
            lettreThree.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreThree.transform.localScale = BoxTwo.transform.localScale;
            lettreThree.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreThree.transform.localScale = BoxThree.transform.localScale;
            lettreThree.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreThree.transform.localScale = BoxFour.transform.localScale;
            lettreThree.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreThree.transform.localScale = BoxFive.transform.localScale;
            lettreThree.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreThree.transform.localScale = BoxSix.transform.localScale;
            lettreThree.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreThree.transform.localScale = BoxSeven.transform.localScale;
            lettreThree.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreThree.transform.localScale = BoxEight.transform.localScale;
            lettreThree.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreThree.transform.localScale = BoxNine.transform.localScale;
            lettreThree.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreThree.transform.position = lettreThreeIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop4
    public void DropLettreFour()
    {
        float Distance = Vector3.Distance(lettreFour.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreFour.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreFour.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreFour.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreFour.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreFour.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreFour.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreFour.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreFour.transform.position, BoxNine.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreFour.transform.localScale = BoxOne.transform.localScale;
            lettreFour.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreFour.transform.localScale = BoxTwo.transform.localScale;
            lettreFour.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreFour.transform.localScale = BoxThree.transform.localScale;
            lettreFour.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreFour.transform.localScale = BoxFour.transform.localScale;
            lettreFour.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreFour.transform.localScale = BoxFive.transform.localScale;
            lettreFour.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreFour.transform.localScale = BoxSix.transform.localScale;
            lettreFour.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreFour.transform.localScale = BoxSeven.transform.localScale;
            lettreFour.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreFour.transform.localScale = BoxEight.transform.localScale;
            lettreFour.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreFour.transform.localScale = BoxNine.transform.localScale;
            lettreFour.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreFour.transform.position = lettreFourIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop5
    public void DropLettreFive()
    {
        float Distance = Vector3.Distance(lettreFive.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreFive.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreFive.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreFive.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreFive.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreFive.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreFive.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreFive.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreFive.transform.position, BoxNine.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreFive.transform.localScale = BoxOne.transform.localScale;
            lettreFive.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreFive.transform.localScale = BoxTwo.transform.localScale;
            lettreFive.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreFive.transform.localScale = BoxThree.transform.localScale;
            lettreFive.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreFive.transform.localScale = BoxFour.transform.localScale;
            lettreFive.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreFive.transform.localScale = BoxFive.transform.localScale;
            lettreFive.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreFive.transform.localScale = BoxSix.transform.localScale;
            lettreFive.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreFive.transform.localScale = BoxSeven.transform.localScale;
            lettreFive.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreFive.transform.localScale = BoxEight.transform.localScale;
            lettreFive.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreFive.transform.localScale = BoxNine.transform.localScale;
            lettreFive.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreFive.transform.position = lettreFiveIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop6
    public void DropLettreSix()
    {
        float Distance = Vector3.Distance(lettreSix.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreSix.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreSix.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreSix.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreSix.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreSix.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreSix.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreSix.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreSix.transform.position, BoxNine.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreSix.transform.localScale = BoxOne.transform.localScale;
            lettreSix.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreSix.transform.localScale = BoxTwo.transform.localScale;
            lettreSix.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreSix.transform.localScale = BoxThree.transform.localScale;
            lettreSix.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreSix.transform.localScale = BoxFour.transform.localScale;
            lettreSix.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreSix.transform.localScale = BoxFive.transform.localScale;
            lettreSix.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreSix.transform.localScale = BoxSix.transform.localScale;
            lettreSix.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreSix.transform.localScale = BoxSeven.transform.localScale;
            lettreSix.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreSix.transform.localScale = BoxEight.transform.localScale;
            lettreSix.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreSix.transform.localScale = BoxNine.transform.localScale;
            lettreSix.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreSix.transform.position = lettreSixIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop7
    public void DropLettreSeven()
    {
        float Distance = Vector3.Distance(lettreSeven.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreSeven.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreSeven.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreSeven.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreSeven.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreSeven.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreSeven.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreSeven.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreSeven.transform.position, BoxNine.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreSeven.transform.localScale = BoxOne.transform.localScale;
            lettreSeven.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreSeven.transform.localScale = BoxTwo.transform.localScale;
            lettreSeven.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreSeven.transform.localScale = BoxThree.transform.localScale;
            lettreSeven.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreSeven.transform.localScale = BoxFour.transform.localScale;
            lettreSeven.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreSeven.transform.localScale = BoxFive.transform.localScale;
            lettreSeven.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreSeven.transform.localScale = BoxSix.transform.localScale;
            lettreSeven.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreSeven.transform.localScale = BoxSeven.transform.localScale;
            lettreSeven.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreSeven.transform.localScale = BoxEight.transform.localScale;
            lettreSeven.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreSeven.transform.localScale = BoxNine.transform.localScale;
            lettreSeven.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreSeven.transform.position = lettreSevenIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop8
    public void DropLettreEight()
    {
        float Distance = Vector3.Distance(lettreEight.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreEight.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreEight.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreEight.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreEight.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreEight.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreEight.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreEight.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreEight.transform.position, BoxNine.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreEight.transform.localScale = BoxOne.transform.localScale;
            lettreEight.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreEight.transform.localScale = BoxTwo.transform.localScale;
            lettreEight.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreEight.transform.localScale = BoxThree.transform.localScale;
            lettreEight.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreEight.transform.localScale = BoxFour.transform.localScale;
            lettreEight.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreEight.transform.localScale = BoxFive.transform.localScale;
            lettreEight.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreEight.transform.localScale = BoxSix.transform.localScale;
            lettreEight.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreEight.transform.localScale = BoxSeven.transform.localScale;
            lettreEight.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreEight.transform.localScale = BoxEight.transform.localScale;
            lettreEight.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreEight.transform.localScale = BoxNine.transform.localScale;
            lettreEight.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreEight.transform.position = lettreEightIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop9
    public void DropLettreNine()
    {
        float Distance = Vector3.Distance(lettreNine.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreNine.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreNine.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreNine.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreNine.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreNine.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreNine.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreNine.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreNine.transform.position, BoxNine.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreNine.transform.localScale = BoxOne.transform.localScale;
            lettreNine.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreNine.transform.localScale = BoxTwo.transform.localScale;
            lettreNine.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreNine.transform.localScale = BoxThree.transform.localScale;
            lettreNine.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreNine.transform.localScale = BoxFour.transform.localScale;
            lettreNine.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreNine.transform.localScale = BoxFive.transform.localScale;
            lettreNine.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreNine.transform.localScale = BoxSix.transform.localScale;
            lettreNine.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreNine.transform.localScale = BoxSeven.transform.localScale;
            lettreNine.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreNine.transform.localScale = BoxEight.transform.localScale;
            lettreNine.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreNine.transform.localScale = BoxNine.transform.localScale;
            lettreNine.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreNine.transform.position = lettreNineIni;
            source.clip = reload;
            source.Play();
        }
    }

    //tombol
    public GameObject feed_benar, feed_salah;

    // pengecekan huruf apakah benar atau salah
    public void Check()
    {
        str = BoxOne.name + BoxTwo.name + BoxThree.name + BoxFour.name + BoxFive.name + BoxSix.name + BoxSeven.name + BoxEight.name + BoxNine.name;
        if ((word == str) || (word2 == str) || (word3 == str) || (word4 == str))
        {
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
            Skordrag.scoremgdua();
            //skordrag.scoreValue += 10;
            kataditemukan();
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();

            if (Skordrag.scorevaluemg2 == Timersettings.scoremax)
            {
                Timersettings.waktuberhenti();
            }
            StartCoroutine(LoadNextPanel());
            /*if (skordrag.scoreValue == Timersettings.scoremax)
            {
                Timersettings.waktuberhenti();
            }*/
        }
        else
        {
            source.clip = incorrect;
            source.Play();
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
            Reload();
        }
    }

    // untuk menuliskan kata yang ditemukan
    public void kataditemukan()
    {
        Kataditemukan = Kataditemukan1 + Kataditemukan2 + Kataditemukan3 + Kataditemukan4 + Kataditemukan5 + Kataditemukan6; // script ini di taro di bagian cek kalo benar
        KatadiTemukan.text = Kataditemukan;
    }

    // reload atau refresh huruf
    public void Reload()
    {
        str = "";

        oneCorrect = false;
        twoCorrect = false;
        threeCorrect = false;
        fourCorrect = false;
        fiveCorrect = false;
        sixCorrect = false;
        sevenCorrect = false;
        eightCorrect = false;
        nineCorrect = false;

        BoxOne.name = "1";
        BoxTwo.name = "2";
        BoxThree.name = "3";
        BoxFour.name = "4";
        BoxFive.name = "5";
        BoxSix.name = "6";
        BoxSeven.name = "7";
        BoxEight.name = "8";
        BoxNine.name = "9";

        lettreOne.transform.position = lettreOneIni;
        lettreTwo.transform.position = lettreTwoIni;
        lettreThree.transform.position = lettreThreeIni;
        lettreFour.transform.position = lettreFourIni;
        lettreFive.transform.position = lettreFiveIni;
        lettreSix.transform.position = lettreSixIni;
        lettreSeven.transform.position = lettreSevenIni;
        lettreEight.transform.position = lettreEightIni;
        lettreNine.transform.position = lettreNineIni;

        lettreOne.transform.localScale = iniScaleLettreOne;
        lettreTwo.transform.localScale = iniScaleLettreTwo;
        lettreThree.transform.localScale = iniScaleLettreThree;
        lettreFour.transform.localScale = iniScaleLettreFour;
        lettreFive.transform.localScale = iniScaleLettreFive;
        lettreSix.transform.localScale = iniScaleLettreSix;
        lettreSeven.transform.localScale = iniScaleLettreSeven;
        lettreEight.transform.localScale = iniScaleLettreEight;
        lettreNine.transform.localScale = iniScaleLettreNine;
    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(2.5f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }
}
