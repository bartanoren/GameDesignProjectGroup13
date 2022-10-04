using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnWalk : MonoBehaviour
{
        public AudioSource[] soundFX;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("W")) {
            soundFX[0].Play();
        }
        if (Input.GetButtonDown("A")) {
            soundFX[1].Play();
        }
        if (Input.GetButtonDown("S")) {
            soundFX[2].Play();
        }
        if (Input.GetButtonDown("D")) {
            soundFX[3].Play();
        }
        if (Input.GetButtonUp("W")) {
            soundFX[0].Stop();
        }
        if (Input.GetButtonUp("A")) {
            soundFX[1].Stop();
        }
        if (Input.GetButtonUp("S")) {
            soundFX[2].Stop();
        }
        if (Input.GetButtonUp("D")) {
            soundFX[3].Stop();
        }
        
        
    }
}
