using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class StartAudio : MonoBehaviour
{
    public AudioClip myClip;

    private AudioSource _audioSource;

    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("Player") ) 
        {
            StopSounds();
            PlaySound();
            gameObject.SetActive(false);
        }
        
    }



    public void PlaySound()
    {
        MMSoundManagerSoundPlayEvent.Trigger(myClip, MMSoundManager.MMSoundManagerTracks.Music, this.transform.position, loop: true, ID: 0);
    }

    public void StopSounds()
    {
        MMSoundManagerAllSoundsControlEvent.Trigger(MMSoundManagerAllSoundsControlEventTypes.Stop);
    }
   
}
