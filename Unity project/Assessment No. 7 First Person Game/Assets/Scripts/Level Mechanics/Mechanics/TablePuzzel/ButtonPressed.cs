using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{

    [SerializeField]
    BoolObject canMove;
    [SerializeField]
    BoolObject MoveDirection;

    private void Start()
    {
        MoveDirection.value = false;
    }

    public void SetMoveDirectionOn()
    {
        if(canMove.value)
        {
            MoveDirection.value = true;
        }
    }
}
