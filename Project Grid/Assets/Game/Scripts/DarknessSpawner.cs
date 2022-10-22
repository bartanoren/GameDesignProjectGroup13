using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarknessSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnerPrefab;

    [SerializeField]
    private float InitialInterval = 3.5f;

    [SerializeField]
    private float IntervalDecreaseValue = 0.1f;

    

    private Vector3 spawnVec = new Vector3(0,0,0);

    [SerializeField]
    private float spawnDistance = 10f;
    
    [SerializeField]
    private double maxEnemyCount = 0d;

    private bool spawnerEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnVec = transform.position;
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!spawnerEnabled)
        {
            print("darkness spawner enabled");
            spawnerEnabled = true;
            StartCoroutine(spawnEnemy(InitialInterval, spawnerPrefab, maxEnemyCount));
        }
    }


    //TODO: ad ontrigger exit to destroy all enemies in this room and also destroy the spawner


    private IEnumerator spawnEnemy(float interval, GameObject enemy, double count)
    {
        if (count > 0){
            print(interval);
            if (interval < 0.1f)
            {
                interval = 0.1f;
            } 
            else 
            {
                interval = interval - IntervalDecreaseValue;
            }

            yield return new WaitForSeconds(interval);
            GameObject newEnemy = Instantiate(enemy, spawnVec + new Vector3(Random.Range(-1 * spawnDistance, spawnDistance), 
            Random.Range(-1 * spawnDistance, spawnDistance), 0) , Quaternion.identity);
            count--;
            StartCoroutine(spawnEnemy(interval, enemy, count));
        }
        
    }
}
