using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.TopDownEngine;

public class SpawnWithoutGuns : MonoBehaviour
{
    public GameObject player;
    public GameObject gun;
    //public GameObject flashlight;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        print("triggered spawn");
        player = collider.gameObject;
        print(player);

        gun = player.transform.GetChild(5).gameObject;
        //flashlight = player.transform.GetChild(6).gameObject;

        gun.GetComponent<WeaponAim2D>().RemoveReticle();

        gun.SetActive(false);
        //flashlight.SetActive(false);

        gameObject.SetActive(false);
    }

}
