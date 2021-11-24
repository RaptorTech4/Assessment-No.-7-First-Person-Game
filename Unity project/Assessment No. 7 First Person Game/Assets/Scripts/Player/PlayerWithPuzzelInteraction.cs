using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWithPuzzelInteraction : MonoBehaviour
{

    public GameObject playerCamera;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, 10.0f))
            {
                if (hit.collider != null)
                {
                    if (hit.transform.gameObject.tag == "KeyPad")
                    {
                        KeyPad(hit.transform.gameObject);
                    }

                    if(hit.transform.gameObject.tag == "WheelPuzzel")
                    {
                        RotateWheel(hit.transform.gameObject);
                    }

                    if (hit.transform.gameObject.tag == "TablePuzzelButtons")
                    {
                        ButtonOnTable(hit.transform.gameObject);
                    }
                    
                }
            }
        }
    }

    public void KeyPad(GameObject hit)
    {
        if (hit.transform.GetComponent<AddNumberToString>() != null)
        {
            hit.transform.GetComponent<AddNumberToString>().AddNumber();
        }

        if (hit.transform.GetComponent<ClearNumbersOfString>() != null)
        {
            hit.transform.GetComponent<ClearNumbersOfString>().removeAllNumber();
        }

        if (hit.transform.GetComponent<VerifaiNumberString>() != null)
        {
            hit.transform.GetComponent<VerifaiNumberString>().CheckIfPasswordIsCorrect();
        }

        if (hit.transform.GetComponent<PlaySound>() != null)
        {
            hit.transform.GetComponent<PlaySound>().PlayASound();
        }
    }

    public void RotateWheel(GameObject hit)
    {
        if(hit.GetComponent<RotateWheel>()!=null)
        {
            hit.GetComponent<RotateWheel>().RotateTheWheel();
        }
    }

    public void ButtonOnTable(GameObject hit)
    {
        hit.GetComponent<ButtonPressed>().SetMoveDirectionOn();
    }
}
