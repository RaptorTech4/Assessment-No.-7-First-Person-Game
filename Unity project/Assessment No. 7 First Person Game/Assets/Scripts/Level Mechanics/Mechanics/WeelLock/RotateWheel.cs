using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    [SerializeField]
    IntObject WheelValue;
    [SerializeField]
    BoolObject valueChanged;

    private bool coroutineAllowed;
    private int numberShown;
    

    private void Start()
    {
        valueChanged.value = false;
        coroutineAllowed = true;
        numberShown = 1;
        WheelValue.value = numberShown;
    }

    public void RotateTheWheel()
    {
        if (coroutineAllowed)
        {
            StartCoroutine("StartRotation");
        }
    }

    private IEnumerator StartRotation()
    {
        coroutineAllowed = false;

        for (int i = 0; i < 11; i++)
        {
            transform.Rotate(0f, 3.644f, 0f);
            yield return new WaitForSeconds(0.01f);
        }

        numberShown += 1;

        if (numberShown > 9)
        {
            numberShown = 1;
            transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        }

        if (numberShown == 0)
        {
            numberShown = 1;
        }

        WheelValue.value = numberShown;

        

        valueChanged.value = true;
        coroutineAllowed = true;

    }

}
