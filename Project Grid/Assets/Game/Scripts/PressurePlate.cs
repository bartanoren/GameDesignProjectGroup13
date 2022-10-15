using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField]
    public Animator myAnim;

    public bool otherPlateEnabled = false;

    GameObject teleporter;

    // Start is called before the first frame update
    void Start()
    {
        print("started pressureplate");
        teleporter = GameObject.Find("ExitDarkness");
        teleporter.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        myAnim.Play("TeleporterAnimation");

        print(teleporter);
    

        if(!otherPlateEnabled)
        {
            otherPlateEnabled = true;
        } 
        else 
        {
            teleporter.SetActive(true);
        }
        
    }
}
