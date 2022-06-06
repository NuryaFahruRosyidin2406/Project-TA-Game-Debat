using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mgduasusunkata : MonoBehaviour
{
    public GameObject lettreOne, lettreTwo, lettreThree, lettreFour, lettreFive, lettreSix, lettreSeven, lettreEight, lettreNine, lettreTen, lettreEleven, lettreTwelve, BoxOne, BoxTwo, BoxThree, BoxFour, BoxFive, BoxSix, BoxSeven, BoxEight, BoxNine, BoxTen, BoxEleven, BoxTwelve;

    Vector3 lettreOneIni, lettreTwoIni, lettreThreeIni, lettreFourIni, lettreFiveIni, lettreSixIni, lettreSevenIni, lettreEightIni, lettreNineIni, lettreTenIni, lettreElevenIni, lettreTwelveIni;

    string str = "";
    public string word;
    public string Kataditemukan, Kataditemukan1, Kataditemukan2, Kataditemukan3, Kataditemukan4, Kataditemukan5, Kataditemukan6, Kataditemukan7, Kataditemukan8, Kataditemukan9, Kataditemukan10, Kataditemukan11, Kataditemukan12;

    public Text KatadiTemukan;

    public GameObject questionToHide, questionToShow;

    bool oneCorrect, twoCorrect, threeCorrect, fourCorrect, fiveCorrect, sixCorrect, sevenCorrect, eightCorrect, nineCorrect, tenCorrect, elevenCorrect, twelveCorrect = false;

    Vector3 iniScaleLettreOne, iniScaleLettreTwo, iniScaleLettreThree, iniScaleLettreFour, iniScaleLettreFive, iniScaleLettreSix, iniScaleLettreSeven, iniScaleLettreEight, iniScaleLettreNine, iniScaleLettreTen, iniScaleLettreEleven, iniScaleLettreTwelve;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    public AudioClip reload;
    public AudioClip buttonDrop;

    //public timersettings Timersettings;

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
        lettreTenIni = lettreTen.transform.position;
        lettreElevenIni = lettreEleven.transform.position;
        lettreTwelveIni = lettreTwelve.transform.position;

        iniScaleLettreOne = lettreOne.transform.localScale;
        iniScaleLettreTwo = lettreTwo.transform.localScale;
        iniScaleLettreThree = lettreThree.transform.localScale;
        iniScaleLettreFour = lettreFour.transform.localScale;
        iniScaleLettreFive = lettreFive.transform.localScale;
        iniScaleLettreSix = lettreSix.transform.localScale;
        iniScaleLettreSeven = lettreSeven.transform.localScale;
        iniScaleLettreEight = lettreEight.transform.localScale;
        iniScaleLettreNine = lettreNine.transform.localScale;
        iniScaleLettreTen = lettreTen.transform.localScale;
        iniScaleLettreEleven = lettreEleven.transform.localScale;
        iniScaleLettreTwelve = lettreTwelve.transform.localScale;
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

    public void DragLettreTen()
    {
        lettreTen.transform.position = Input.mousePosition;
    }

    public void DragLettreEleven()
    {
        lettreEleven.transform.position = Input.mousePosition;
    }

    public void DragLettreTwelve()
    {
        lettreTwelve.transform.position = Input.mousePosition;
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
        float Distance10 = Vector3.Distance(lettreOne.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreOne.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreOne.transform.position, BoxTwelve.transform.position);

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

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreOne.transform.localScale = BoxTen.transform.localScale;
            lettreOne.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreOne.transform.localScale = BoxEleven.transform.localScale;
            lettreOne.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreOne.transform.localScale = BoxTwelve.transform.localScale;
            lettreOne.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreOne.name;
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
        float Distance10 = Vector3.Distance(lettreTwo.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreTwo.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreTwo.transform.position, BoxTwelve.transform.position);

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

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreTwo.transform.localScale = BoxTen.transform.localScale;
            lettreTwo.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreTwo.transform.localScale = BoxEleven.transform.localScale;
            lettreTwo.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreTwo.transform.localScale = BoxTwelve.transform.localScale;
            lettreTwo.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreTwo.name;
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
        float Distance10 = Vector3.Distance(lettreThree.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreThree.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreThree.transform.position, BoxTwelve.transform.position);

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

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreThree.transform.localScale = BoxTen.transform.localScale;
            lettreThree.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreThree.transform.localScale = BoxEleven.transform.localScale;
            lettreThree.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreThree.transform.localScale = BoxTwelve.transform.localScale;
            lettreThree.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreThree.name;
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
        float Distance10 = Vector3.Distance(lettreFour.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreFour.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreFour.transform.position, BoxTwelve.transform.position);

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

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreFour.transform.localScale = BoxTen.transform.localScale;
            lettreFour.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreFour.transform.localScale = BoxEleven.transform.localScale;
            lettreFour.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreFour.transform.localScale = BoxTwelve.transform.localScale;
            lettreFour.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreFour.name;
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
        float Distance10 = Vector3.Distance(lettreFive.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreFive.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreFive.transform.position, BoxTwelve.transform.position);

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

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreFive.transform.localScale = BoxTen.transform.localScale;
            lettreFive.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreFive.transform.localScale = BoxEleven.transform.localScale;
            lettreFive.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreFive.transform.localScale = BoxTwelve.transform.localScale;
            lettreFive.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreFive.name;
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
        float Distance10 = Vector3.Distance(lettreSix.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreSix.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreSix.transform.position, BoxTwelve.transform.position);

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

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreSix.transform.localScale = BoxTen.transform.localScale;
            lettreSix.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreSix.transform.localScale = BoxEleven.transform.localScale;
            lettreSix.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreSix.transform.localScale = BoxTwelve.transform.localScale;
            lettreSix.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreSix.name;
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
        float Distance10 = Vector3.Distance(lettreSeven.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreSeven.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreSeven.transform.position, BoxTwelve.transform.position);

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

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreSeven.transform.localScale = BoxTen.transform.localScale;
            lettreSeven.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreSeven.transform.localScale = BoxEleven.transform.localScale;
            lettreSeven.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreSeven.transform.localScale = BoxTwelve.transform.localScale;
            lettreSeven.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreSeven.name;
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
        float Distance10 = Vector3.Distance(lettreEight.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreEight.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreEight.transform.position, BoxTwelve.transform.position);

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

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreEight.transform.localScale = BoxTen.transform.localScale;
            lettreEight.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreEight.transform.localScale = BoxEleven.transform.localScale;
            lettreEight.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreEight.transform.localScale = BoxTwelve.transform.localScale;
            lettreEight.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreEight.name;
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
        float Distance10 = Vector3.Distance(lettreNine.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreNine.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreNine.transform.position, BoxTwelve.transform.position);

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

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreNine.transform.localScale = BoxTen.transform.localScale;
            lettreNine.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreNine.transform.localScale = BoxEleven.transform.localScale;
            lettreNine.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreNine.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreNine.transform.localScale = BoxTwelve.transform.localScale;
            lettreNine.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreNine.name;
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

    //dragdrop10
    public void DropLettreTen()
    {
        float Distance = Vector3.Distance(lettreTen.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreTen.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreTen.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreTen.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreTen.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreTen.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreTen.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreTen.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreTen.transform.position, BoxNine.transform.position);
        float Distance10 = Vector3.Distance(lettreTen.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreTen.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreTen.transform.position, BoxTwelve.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreTen.transform.localScale = BoxOne.transform.localScale;
            lettreTen.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreTen.transform.localScale = BoxTwo.transform.localScale;
            lettreTen.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreTen.transform.localScale = BoxThree.transform.localScale;
            lettreTen.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreTen.transform.localScale = BoxFour.transform.localScale;
            lettreTen.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreTen.transform.localScale = BoxFive.transform.localScale;
            lettreTen.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreTen.transform.localScale = BoxSix.transform.localScale;
            lettreTen.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreTen.transform.localScale = BoxSeven.transform.localScale;
            lettreTen.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreTen.transform.localScale = BoxEight.transform.localScale;
            lettreTen.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreTen.transform.localScale = BoxNine.transform.localScale;
            lettreTen.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreTen.transform.localScale = BoxTen.transform.localScale;
            lettreTen.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreTen.transform.localScale = BoxEleven.transform.localScale;
            lettreTen.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreTen.transform.localScale = BoxTwelve.transform.localScale;
            lettreTen.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreTen.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreTen.transform.position = lettreTenIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop11
    public void DropLettreEleven()
    {
        float Distance = Vector3.Distance(lettreEleven.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreEleven.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreEleven.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreEleven.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreEleven.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreEleven.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreEleven.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreEleven.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreEleven.transform.position, BoxNine.transform.position);
        float Distance10 = Vector3.Distance(lettreEleven.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreEleven.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreEleven.transform.position, BoxTwelve.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreEleven.transform.localScale = BoxOne.transform.localScale;
            lettreEleven.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreEleven.transform.localScale = BoxTwo.transform.localScale;
            lettreEleven.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreEleven.transform.localScale = BoxThree.transform.localScale;
            lettreEleven.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreEleven.transform.localScale = BoxFour.transform.localScale;
            lettreEleven.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreEleven.transform.localScale = BoxFive.transform.localScale;
            lettreEleven.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreEleven.transform.localScale = BoxSix.transform.localScale;
            lettreEleven.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreEleven.transform.localScale = BoxSeven.transform.localScale;
            lettreEleven.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreEleven.transform.localScale = BoxEight.transform.localScale;
            lettreEleven.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreEleven.transform.localScale = BoxNine.transform.localScale;
            lettreEleven.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreEleven.transform.localScale = BoxTen.transform.localScale;
            lettreEleven.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreEleven.transform.localScale = BoxEleven.transform.localScale;
            lettreEleven.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreEleven.transform.localScale = BoxTwelve.transform.localScale;
            lettreEleven.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreEleven.transform.position = lettreElevenIni;
            source.clip = reload;
            source.Play();
        }
    }

    //dragdrop12
    public void DropLettreTwelve()
    {
        float Distance = Vector3.Distance(lettreTwelve.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreTwelve.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreTwelve.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreTwelve.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreTwelve.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreTwelve.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreTwelve.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(lettreTwelve.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(lettreTwelve.transform.position, BoxNine.transform.position);
        float Distance10 = Vector3.Distance(lettreTwelve.transform.position, BoxTen.transform.position);
        float Distance11 = Vector3.Distance(lettreTwelve.transform.position, BoxEleven.transform.position);
        float Distance12 = Vector3.Distance(lettreTwelve.transform.position, BoxTwelve.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxOne.transform.localScale;
            lettreTwelve.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxTwo.transform.localScale;
            lettreTwelve.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxThree.transform.localScale;
            lettreTwelve.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance4 < 50 && fourCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxFour.transform.localScale;
            lettreTwelve.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxFive.transform.localScale;
            lettreTwelve.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxSix.transform.localScale;
            lettreTwelve.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxSeven.transform.localScale;
            lettreTwelve.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxEight.transform.localScale;
            lettreTwelve.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxNine.transform.localScale;
            lettreTwelve.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxTen.transform.localScale;
            lettreTwelve.transform.position = BoxTen.transform.position;
            tenCorrect = true;
            BoxTen.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxEleven.transform.localScale;
            lettreTwelve.transform.position = BoxEleven.transform.position;
            elevenCorrect = true;
            BoxEleven.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance12 < 50 && twelveCorrect == false)
        {
            lettreTwelve.transform.localScale = BoxTwelve.transform.localScale;
            lettreTwelve.transform.position = BoxTwelve.transform.position;
            twelveCorrect = true;
            BoxTwelve.name = lettreTwelve.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreTwelve.transform.position = lettreTwelveIni;
            source.clip = reload;
            source.Play();
        }
    }

    //tombol
    public GameObject feed_benar, feed_salah;

    // pengecekan huruf apakah benar atau salah
    public void Check()
    {
        str = BoxOne.name + BoxTwo.name + BoxThree.name + BoxFour.name + BoxFive.name + BoxSix.name + BoxSeven.name + BoxEight.name + BoxNine.name + BoxTen.name + BoxEleven.name + BoxTwelve.name;
        if (word == str)
        {
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
            //skordrag.scoreValue += 10;
            kataditemukan();
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            StartCoroutine(LoadNextPanel());
            /*if (skordrag.scoreValue == 20)
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
        }
    }

    // untuk menuliskan kata yang ditemukan
    public void kataditemukan()
    {
        Kataditemukan = Kataditemukan1 + Kataditemukan2 + Kataditemukan3 + Kataditemukan4 + Kataditemukan5 + Kataditemukan6 + Kataditemukan7 + Kataditemukan8 + Kataditemukan9 + Kataditemukan10 + Kataditemukan11 + Kataditemukan12; // script ini di taro di bagian cek kalo benar
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
        tenCorrect = false;
        elevenCorrect = false;
        twelveCorrect = false;

        BoxOne.name = "1";
        BoxTwo.name = "2";
        BoxThree.name = "3";
        BoxFour.name = "4";
        BoxFive.name = "5";
        BoxSix.name = "6";
        BoxSeven.name = "7";
        BoxEight.name = "8";
        BoxNine.name = "9";
        BoxTen.name = "10";
        BoxEleven.name = "11";
        BoxTwelve.name = "12";

        lettreOne.transform.position = lettreOneIni;
        lettreTwo.transform.position = lettreTwoIni;
        lettreThree.transform.position = lettreThreeIni;
        lettreFour.transform.position = lettreFourIni;
        lettreFive.transform.position = lettreFiveIni;
        lettreSix.transform.position = lettreSixIni;
        lettreSeven.transform.position = lettreSevenIni;
        lettreEight.transform.position = lettreEightIni;
        lettreNine.transform.position = lettreNineIni;
        lettreTen.transform.position = lettreTenIni;
        lettreEleven.transform.position = lettreElevenIni;
        lettreTwelve.transform.position = lettreTwelveIni;

        lettreOne.transform.localScale = iniScaleLettreOne;
        lettreTwo.transform.localScale = iniScaleLettreTwo;
        lettreThree.transform.localScale = iniScaleLettreThree;
        lettreFour.transform.localScale = iniScaleLettreFour;
        lettreFive.transform.localScale = iniScaleLettreFive;
        lettreSix.transform.localScale = iniScaleLettreSix;
        lettreSeven.transform.localScale = iniScaleLettreSeven;
        lettreEight.transform.localScale = iniScaleLettreEight;
        lettreNine.transform.localScale = iniScaleLettreNine;
        lettreTen.transform.localScale = iniScaleLettreTen;
        lettreEleven.transform.localScale = iniScaleLettreEleven;
        lettreTwelve.transform.localScale = iniScaleLettreTwelve;
    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(3f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }
}
