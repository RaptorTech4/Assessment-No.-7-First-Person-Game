using UnityEngine;

public class TimerCountDown : MonoBehaviour
{

    [SerializeField] FloatObject timeRemaining;

    private void Awake()
    {
        InvokeRepeating("RemoveSecondFromTimer", 5, 1);  
    }

    void RemoveSecondFromTimer()
    {
        if (timeRemaining.value > 0f)
        {
            timeRemaining.value--;
        }

        if(timeRemaining.value < 0f)
        {
            timeRemaining.value = 0f;
        }

    }
}
