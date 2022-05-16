using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Expression;

public class CharAnim : MonoBehaviour
{
    public Animator charAnimController;
    public CubismExpressionController expressionController;

    private void Start()
    {
        charAnimController = GetComponent<Animator>();
        expressionController = GetComponent<CubismExpressionController>();
    }

    public void CharacterMotion(string animationName)
    {
        charAnimController.SetTrigger(animationName);
    }

    public void CharacterExpression(int expression)
    {
        expressionController.CurrentExpressionIndex = expression;
    }
}
