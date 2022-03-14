using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerMovement : MonoBehaviour
{
    private Transform pointA;
    private Transform pointB;
    private Transform pointC;
    private Transform pointD;
    private Transform pointABCD;


    private bool move = false;
    private int duplicate;
    private float interpolateAmount;

    // Update is called once per frame
    private void Update()
    {
        duplicate = GameObject.FindGameObjectsWithTag("Answer").Length;
        if (duplicate >= 1 && move == false)
        {
            pointA = GameObject.FindGameObjectWithTag("PointA").transform;
            pointB = GameObject.FindGameObjectWithTag("PointB").transform;
            pointC = GameObject.FindGameObjectWithTag("PointC").transform;
            pointD = GameObject.FindGameObjectWithTag("PointD").transform;
            pointABCD = GameObject.FindGameObjectWithTag("Answer").transform;
            move = true;
        }
        else
        {
            Debug.Log("Waduh");
            interpolateAmount = (interpolateAmount + Time.deltaTime) % 1f;
            pointABCD.position = CubicLerp(pointA.position, pointB.position, pointC.position, pointD.position, interpolateAmount);
        }
    }

    private Vector3 QuadraticLerp(Vector3 a, Vector3 b, Vector3 c, float t)
    {
        Vector3 ab = Vector3.Lerp(a, b, t);
        Vector3 bc = Vector3.Lerp(b, c, t);

        return Vector3.Lerp(ab, bc, interpolateAmount);
    }

    private Vector3 CubicLerp(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t)
    {
        Vector3 ab_bc = QuadraticLerp(a, b, c, t);
        Vector3 bc_cd = QuadraticLerp(b, c, d, t);

        return Vector3.Lerp(ab_bc, bc_cd, interpolateAmount);
    }
}
