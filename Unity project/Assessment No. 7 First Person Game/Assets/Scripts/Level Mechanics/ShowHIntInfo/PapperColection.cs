using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapperColection : MonoBehaviour
{

    [SerializeField]
    private BoolObject PapperActive;

    void Start()
    {
        PapperActive.value = false;
        gameObject.SetActive(true);
    }

    public void PapperColected()
    {
        PapperActive.value = true;
        gameObject.SetActive(false);
    }

}
