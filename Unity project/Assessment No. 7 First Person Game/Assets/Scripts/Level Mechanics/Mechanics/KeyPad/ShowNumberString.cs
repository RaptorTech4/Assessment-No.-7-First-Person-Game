using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowNumberString : MonoBehaviour
{

    [SerializeField]
    stringObject NumPad;
    [SerializeField]
    TextMeshPro outputText;

    private void Start()
    {
        NumPad.value = "";
    }

    private void Update()
    {
        if(outputText.text != NumPad.value)
        {
            outputText.text = NumPad.value;
        }
    }
}
