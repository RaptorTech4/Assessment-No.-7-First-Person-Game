using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearNumbersOfString : MonoBehaviour
{
    [SerializeField]
    stringObject NumPad;

    public void removeAllNumber()
    {
        if (NumPad != null)
            NumPad.value = "";
    }

}
