using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrantWeapons : MonoBehaviour
{
    public GameObject player;
    public GameObject gun;
    public GameObject flashlight;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        player = collider.gameObject;

        gun = player.transform.GetChild(5).gameObject;
        flashlight = player.transform.GetChild(6).gameObject;

        gun.SetActive(true);
        flashlight.SetActive(true);
    }

}
