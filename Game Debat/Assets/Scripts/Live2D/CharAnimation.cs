using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimation : MonoBehaviour
{
    private Animator charAnim;
    private Live2D.Cubism.Framework.Expression.CubismExpressionController expressionControl;

    void Start()
    {
        charAnim = GetComponent<Animator>();
        expressionControl = GetComponent<Live2D.Cubism.Framework.Expression.CubismExpressionController>();
    }

    void Update()
    {
        CharacterMotion();
        FacialExpression();
    }

    void CharacterMotion()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            charAnim.SetTrigger("wavingHandTrigger");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            charAnim.SetTrigger("agreeWithYouTrigger");
        }
    }

    void FacialExpression()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            expressionControl.CurrentExpressionIndex = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            expressionControl.CurrentExpressionIndex = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            expressionControl.CurrentExpressionIndex = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            expressionControl.CurrentExpressionIndex = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            expressionControl.CurrentExpressionIndex = 4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            expressionControl.CurrentExpressionIndex = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            expressionControl.CurrentExpressionIndex = 6;
        }
    }
}
