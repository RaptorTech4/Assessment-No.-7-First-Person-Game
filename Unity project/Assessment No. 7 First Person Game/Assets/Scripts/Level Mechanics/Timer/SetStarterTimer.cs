using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStarterTimer : MonoBehaviour
{

    public FloatObject starterTime;
    public FloatObject currentTime;

    void Start()
    {
        currentTime.value = starterTime.value;
    }
}
