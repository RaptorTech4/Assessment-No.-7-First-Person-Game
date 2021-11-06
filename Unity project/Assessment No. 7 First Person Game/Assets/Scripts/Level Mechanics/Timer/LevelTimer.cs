using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    public FloatObject timeRemaining;
    bool timerIsRunning = false;

    public BoolObject PlayerLost;

    private void Start()
    {
        timerIsRunning = true;
        PlayerLost.value = false;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining.value > 0)
            {
                timeRemaining.value -= Time.deltaTime;
            }
            else
            {
                timeRemaining.value = 0;
                timerIsRunning = false;
                PlayerLost.value = true;
            }
        }
    }
}
