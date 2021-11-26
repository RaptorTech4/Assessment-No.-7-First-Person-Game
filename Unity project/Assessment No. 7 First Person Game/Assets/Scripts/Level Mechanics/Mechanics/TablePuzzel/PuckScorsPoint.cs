using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckScorsPoint : MonoBehaviour
{

    [SerializeField]
    BoolObject ValueToChange;
    [SerializeField]
    MeshRenderer changeColor;
    [SerializeField]
    Material OnMat, OffMat;

    void Start()
    {
        ValueToChange.value = false;
        if(changeColor!=null)
        {
            changeColor.material = OffMat;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        print("somthing toched me");

        if(other.gameObject.tag == "Puck")
        {
            print("A puck toched me");

            ValueToChange.value = true;
            changeColor.material = OnMat;
        }
    }
}
