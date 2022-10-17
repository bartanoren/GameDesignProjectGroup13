using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField]
    public Animator myAnim;

    [SerializeField]
    public GameObject teleporter;

    [SerializeField]
    public GameObject currentPlate;

    public static int collisionCount = 0;

    private Collider2D m_Collider;

    private GameObject[] checkMarks;

    // Start is called before the first frame update
    void Start()
    {

        m_Collider = currentPlate.GetComponent<Collider2D>();

        teleporter.SetActive(false);

        
        collisionCount++;
        
        print(collisionCount);
    }
        


    public void OnTriggerEnter2D(Collider2D collider)
    {
        myAnim.Play("TeleporterAnimation");

        m_Collider.enabled = false;
        collisionCount--;

        print(collisionCount);
        
        if(collisionCount == 0)
        {
            teleporter.SetActive(true);
        }
        
        
    }
}
