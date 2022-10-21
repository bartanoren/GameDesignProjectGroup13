using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroy : MonoBehaviour
{
    [SerializeField]
    public GameObject obj;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(obj);
    }

    
}
