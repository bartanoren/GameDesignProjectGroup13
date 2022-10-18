using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class StopAudio : MonoBehaviour
{
    public AudioClip myClip;


    public void OnTriggerEnter2D(Collider2D collider)
    {
        StopSound();
        gameObject.SetActive(false);
    }

   
    public void StopSound()
    {
        MMSoundManagerAllSoundsControlEvent.Trigger(MMSoundManagerAllSoundsControlEventTypes.Stop);
    }
}
