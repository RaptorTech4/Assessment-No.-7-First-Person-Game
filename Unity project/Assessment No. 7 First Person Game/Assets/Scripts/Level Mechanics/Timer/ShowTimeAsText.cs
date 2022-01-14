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

    private void Start()
    {
        InvokeRepeating("DisplayTime", 1, 1);
    }

    void DisplayTime()
    {
        float minutes = Mathf.FloorToInt(currentTimeLeft.value / 60);
        float seconds = Mathf.FloorToInt(currentTimeLeft.value % 60);

        outputText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
