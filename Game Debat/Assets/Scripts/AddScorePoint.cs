using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScorePoint : MonoBehaviour
{
    public int Point;
    public int Highpoint;

    public Text Pointtext;
    public Text Highpointtext;

    // Start is called before the first frame update
    void Start()
    {
        Highpoint = PlayerPrefs.GetInt("HighPoint");
    }

    // Update is called once per frame
    void Update()
    {
        Pointtext.text = Point.ToString();
        Highpointtext.text = Highpoint.ToString();

        if (Point > Highpoint)
        {
            PlayerPrefs.SetInt("HighPoint", Point);
        }
    }

    public void AddPoint()
    {
        Point++;
    }

    public void DeletePoint()
    {
        PlayerPrefs.DeleteKey("HighPoint");
        Highpointtext.text = "No High Point Yet";
    }
}
