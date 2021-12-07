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

    [SerializeField]
    GameObject HintPannelBoard;

    [Header("HintMaterials")]
    [SerializeField]
    Material defaltHintMat;
    [SerializeField]
    Material FirsHintMat;
    [SerializeField]
    Material SecondHintMat;
    [SerializeField]
    Material ThirdHintMat;
    [SerializeField]
    Material FourthHintMat;



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
