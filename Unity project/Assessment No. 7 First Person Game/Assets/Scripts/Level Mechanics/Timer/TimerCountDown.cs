using UnityEngine;

public class TimerCountDown : MonoBehaviour
{
    public FloatObject timeRemaining;

    void Update()
    {
        if (timeRemaining.value > 0f)
        {
            timeRemaining.value -= Time.deltaTime;
        }

        if(timeRemaining.value<0f)
        {
            timeRemaining.value = 0f;
        }

    }
}
