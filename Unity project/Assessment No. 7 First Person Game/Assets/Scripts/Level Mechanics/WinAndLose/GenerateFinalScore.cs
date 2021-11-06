using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFinalScore : MonoBehaviour
{

    [SerializeField]
    FloatObject timeRemaining;
    [SerializeField]
    IntObject finalScore;

    [SerializeField]
    BoolObject playerWin;
    [SerializeField]
    BoolObject playerLost;



    void Start()
    {
        finalScore.value = 0;
    }

    void Update()
    {
        if(playerLost.value || playerWin.value)
        {
            int myInt = Mathf.FloorToInt(timeRemaining.value);
            finalScore.value = myInt;
        }
    }
}
