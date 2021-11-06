using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifaiNumberString : MonoBehaviour
{

    [Header("Password")]
    [SerializeField]
    stringObject theRightPassword;
    [SerializeField]
    BoolObject UnlockLock;
    [SerializeField]
    stringObject tipedInpassword;
    [Header("Audio")]
    AudioSource audioOutput;
    [SerializeField]
    AudioClip Correct;
    [SerializeField]
    AudioClip InCorrect;

    private void Start()
    {
        audioOutput = GetComponent<AudioSource>();
        UnlockLock.value = false;
    }

    public void CheckIfPasswordIsCorrect()
    {
        if(tipedInpassword.value == theRightPassword.value)
        {
            CorrectPassword();
        }
        else
        {
            InCorrectPassword();
        }
    }

    public void CorrectPassword()
    {
        //audio
        audioOutput.clip = Correct;
        audioOutput.Play();
        
        UnlockLock.value = true;
        
        print("Success");
    }

    public void InCorrectPassword()
    {
        //audio
        audioOutput.clip = InCorrect;
        audioOutput.Play();
        
        if(!UnlockLock.value)
        {
            UnlockLock.value = false;
        }

        print("Failed");
    }
}
