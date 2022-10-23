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

    public static int collisionCount = 3;

    private Collider2D m_Collider;

    [SerializeField]
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        
        m_Collider = currentPlate.GetComponent<Collider2D>();

        teleporter.SetActive(false);

        light.SetActive(false);
        
        //collisionCount++;
        print(collisionCount);
        
        print(collisionCount);
    }
        

    //TODO: add player only detection for the collision
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") ) 
        {
            
            myAnim.Play("TeleporterAnimation");
            light.SetActive(true);

            m_Collider.enabled = false;
            collisionCount--;

            print(collisionCount);
            
            if(collisionCount == 0)
            {
                teleporter.SetActive(true);
            }
            
        }
    }
}
