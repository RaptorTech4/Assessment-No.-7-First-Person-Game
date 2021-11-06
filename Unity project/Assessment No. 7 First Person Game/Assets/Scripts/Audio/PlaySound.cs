using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    [SerializeField]
    AudioSource audioOutpoet;
    [SerializeField]
    AudioClip audioToPlay;

    public bool SetAudioClipAtStart;

    private void Start()
    {
        if(SetAudioClipAtStart)
        {
            if(audioOutpoet != null)
            {
                audioOutpoet.clip = audioToPlay;
            }
        }
    }

    public void PlayASound()
    {
        if(audioOutpoet!=null)
        {
            if (audioToPlay != null)
            {
                audioOutpoet.Play();
            }
        }
    }
}
