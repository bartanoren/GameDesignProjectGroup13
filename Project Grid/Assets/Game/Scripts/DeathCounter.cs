using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCounter : MonoBehaviour
{
    private static int deathCount = -1;

    Text deathCounter;
    // Start is called before the first frame update

    void Start()
    {
        deathCount++;
        deathCounter = gameObject.GetComponent<Text>();
        deathCounter.text = "Death Count: " + deathCount;
        
    }

    // Update is called once per frame
}
