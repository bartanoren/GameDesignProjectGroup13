using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchOptimiser : MonoBehaviour
{
    private GameObject torchLight;

    private bool childActive = false;

    // Start is called before the first frame update
    void Start()
    {
        torchLight = gameObject.transform.GetChild(0).gameObject;
        torchLight.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        print("enter torch");
        if (!childActive && collider.CompareTag("Player") )
        {
            torchLight.SetActive(true);
            childActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        print("left torch");
        if (collider.CompareTag("Player"))
        {
            torchLight.SetActive(false);
            childActive = false;
        }
    }
}
