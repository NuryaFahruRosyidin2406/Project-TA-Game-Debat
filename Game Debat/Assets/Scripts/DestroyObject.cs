using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
