using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSoundAudioVolume : MonoBehaviour
{

    public FloatObject VolumeObject;
    private AudioSource Source;

    private void Awake()
    {
        Source = gameObject.GetComponent<AudioSource>();
        if(Source != null)
        {
            Source.volume = VolumeObject.value;
        }
    }

    private void Update()
    {
        if(Source!=null)
        {
            if(Source.volume != VolumeObject.value)
            {
               Source.volume = VolumeObject.value;
            }
        }
    }
}
