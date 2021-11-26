using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpTimer : MonoBehaviour
{

    [SerializeField]
    FloatObject CurrentTimer;
    [SerializeField]
    FloatObject AddedAmount;

    void Start()
    {
        CurrentTimer.value = 0f;
    }

    
    public void ButtonPressedCheck()
    {
        if(CurrentTimer.value <= 0f)
        {
            CurrentTimer.value = AddedAmount.value;
        }
    }
}
