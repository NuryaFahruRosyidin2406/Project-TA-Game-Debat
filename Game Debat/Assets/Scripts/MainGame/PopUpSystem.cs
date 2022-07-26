using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpSystem : MonoBehaviour
{
    // Initialize object to refrence in Unity Inspector
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text popUpText;

    // Pop Up Animation
    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        animator.SetTrigger("pop");
    }
}
