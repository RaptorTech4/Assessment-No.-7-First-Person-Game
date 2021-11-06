using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNumberToString : MonoBehaviour
{
    [SerializeField]
    string NumberToAdd;
    [SerializeField]
    stringObject NumPad;
    [SerializeField]
    IntObject NumPadLenth;

    public void AddNumber()
    {
        if(NumberToAdd != null)
            if (NumPad != null)
                if(NumPad.value.Length< NumPadLenth.value)
                    NumPad.value = NumPad.value + NumberToAdd;
    }

}
