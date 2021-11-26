using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssineRandomMat : MonoBehaviour
{

    MeshRenderer myMech;
    [SerializeField]
    Material[] diverintMat;

    void Start()
    {

        int RandemValue = Random.Range(0,diverintMat.Length);

        myMech = GetComponent<MeshRenderer>();

        myMech.material = diverintMat[RandemValue];

    }
}
