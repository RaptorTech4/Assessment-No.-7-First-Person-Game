using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButtonPressed : MonoBehaviour
{

    [SerializeField]
    FloatObject HintTimer;
    [SerializeField]
    IntObject CurrentPuzzelOn;
    [SerializeField]
    IntObject AmountOfHintsTaken;

    void Start()
    {
        AmountOfHintsTaken.value = 0;
    }

    public void ShowHint()
    {
        if(HintTimer.value <=0)
        {
            AmountOfHintsTaken.value++;
            
        }
    }

}
