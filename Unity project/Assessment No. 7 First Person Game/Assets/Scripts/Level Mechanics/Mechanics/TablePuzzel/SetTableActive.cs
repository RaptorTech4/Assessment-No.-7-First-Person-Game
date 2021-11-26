using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTableActive : MonoBehaviour
{
    // ActivateTable

    [SerializeField]
    BoolObject PuckKanMove;

    public GameObject ThePuck;

    private void Start()
    {
        PuckKanMove.value = false;
    }

    public void SetPuckActive()
    {

        ThePuck.SetActive(true);
        gameObject.SetActive(false);

    }
}
