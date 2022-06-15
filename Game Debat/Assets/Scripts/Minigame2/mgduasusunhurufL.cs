using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mgduasusunhurufL : MonoBehaviour
{
    public GameObject lettreOne, lettreTwo, lettreThree, lettreFour, lettreFive, BoxOne, BoxTwo, BoxThree, BoxFour, BoxFive;

    Vector3 lettreOneIni, lettreTwoIni, lettreThreeIni, lettreFourIni, lettreFiveIni;

    string str = "";
    public string word;
    public string Kataditemukan, Kataditemukan1, Kataditemukan2, Kataditemukan3, Kataditemukan4, Kataditemukan5, Kataditemukan6;

    public Text KatadiTemukan;

    public GameObject questionToHide, questionToShow;

    bool oneCorrect, twoCorrect, threeCorrect, fourCorrect, fiveCorrect = false;

    Vector3 iniScaleLettreOne, iniScaleLettreTwo, iniScaleLettreThree, iniScaleLettreFour, iniScaleLettreFive;

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

        iniScaleLettreOne = lettreOne.transform.localScale;
        iniScaleLettreTwo = lettreTwo.transform.localScale;
        iniScaleLettreThree = lettreThree.transform.localScale;
        iniScaleLettreFour = lettreFour.transform.localScale;
        iniScaleLettreFive = lettreFive.transform.localScale;
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

    //dragdrop1
    public void DropLettreOne()
    {
        float Distance = Vector3.Distance(lettreOne.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreOne.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreOne.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreOne.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreOne.transform.position, BoxFive.transform.position);

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

        else
        {
            lettreFive.transform.position = lettreFiveIni;
            source.clip = reload;
            source.Play();
        }
    }

    //tombol
    public GameObject feed_benar, feed_salah;

    // pengecekan huruf apakah benar atau salah
    public void Check()
    {
        str = BoxOne.name + BoxTwo.name + BoxThree.name + BoxFour.name + BoxFive.name;
        if (word == str)
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

        BoxOne.name = "1";
        BoxTwo.name = "2";
        BoxThree.name = "3";
        BoxFour.name = "4";
        BoxFive.name = "5";

        lettreOne.transform.position = lettreOneIni;
        lettreTwo.transform.position = lettreTwoIni;
        lettreThree.transform.position = lettreThreeIni;
        lettreFour.transform.position = lettreFourIni;
        lettreFive.transform.position = lettreFiveIni;

        lettreOne.transform.localScale = iniScaleLettreOne;
        lettreTwo.transform.localScale = iniScaleLettreTwo;
        lettreThree.transform.localScale = iniScaleLettreThree;
        lettreFour.transform.localScale = iniScaleLettreFour;
        lettreFive.transform.localScale = iniScaleLettreFive;
    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(2.5f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }
}
