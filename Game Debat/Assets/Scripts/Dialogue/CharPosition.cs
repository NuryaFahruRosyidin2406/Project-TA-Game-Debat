using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharPosition : MonoBehaviour
{
        private Vector3 target;

    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveCharacter();
    }

    public void moveCharacter()
    {
        float step = speed * Time.deltaTime * 10;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    public void setTarget(Vector3 targetPos, float moveSpeed)
    {
        target = targetPos;
        speed = moveSpeed;
    }
}
