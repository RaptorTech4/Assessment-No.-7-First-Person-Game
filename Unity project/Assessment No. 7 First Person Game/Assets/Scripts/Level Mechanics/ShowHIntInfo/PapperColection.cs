using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapperColection : MonoBehaviour
{

    [SerializeField]
    private BoolObject PapperActive;

    [SerializeField]
    ShowPages UpdatePagesUI;

    void Start()
    {
        PapperActive.value = false;
        gameObject.SetActive(true);
    }

    public void PapperColected()
    {
        PapperActive.value = true;
        gameObject.SetActive(false);

        if(UpdatePagesUI != null)
        {
            UpdatePagesUI.UpdateButtons();
        }
    }

}
