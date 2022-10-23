using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBurstSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnerPrefab;

    [SerializeField]
    private float spawnerInterval = 3.5f;

    private Vector3 spawnVec = new Vector3(0,0,0);

    [SerializeField]
    private float spawnDistance = 6.5f;

    [SerializeField]
    private float burstCount = 5f;

    private bool spawnerEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnVec = transform.position;
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") ) 
        {
            if (!spawnerEnabled)
            {
                spawnerEnabled = true;
                StartCoroutine(spawnEnemy(spawnerInterval, spawnerPrefab, burstCount));
            }
        }
    }


    //TODO: ad ontrigger exit to destroy all enemies in this room and also destroy the spawner


    private IEnumerator spawnEnemy(float interval, GameObject enemy, float count)
    {
        
        yield return new WaitForSeconds(interval);
        for (int i = 0, i < count, i++)
        {
            GameObject newEnemy = Instantiate(enemy, spawnVec + new Vector3(Random.Range(-1 * spawnDistance, spawnDistance), 
            Random.Range(-1 * spawnDistance, spawnDistance), 0) , Quaternion.identity);
        }  
        
        StartCoroutine(spawnEnemy(interval, enemy, count));
        
        
    }
}
