using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTimeAsText : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro outputText;
    [SerializeField]
    FloatObject currentTimeLeft;

    private void Update()
    {
        DisplayTime(currentTimeLeft.value);
    }

    void DisplayTime(float timeToDisplay)
    {
        //timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        outputText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
