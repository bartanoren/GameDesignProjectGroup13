using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [Header("Prefab")]
    [SerializeField]
    private GameObject spawnerPrefab;

    [SerializeField]
    private float spawnerInterval = 3.5f;

    private Vector3 spawnVec = new Vector3(0,0,0);

    [SerializeField]
    private float spawnDistance = 10f;
    
    [SerializeField]
    private double maxEnemyCount = 0d;

    Collider2D m_Collider;

    private bool spawnerEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        print("running");
        spawnVec = transform.position;

        m_Collider = GetComponent<Collider2D>();
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        print("OnTriggerEnter2D detected");
        if (!spawnerEnabled)
        {
            spawnerEnabled = true;
            StartCoroutine(spawnEnemy(spawnerInterval, spawnerPrefab, maxEnemyCount));
        }
    }


    //TODO: ad ontrigger exit to destroy all enemies in this room and also destroy the spawner


    private IEnumerator spawnEnemy(float interval, GameObject enemy, double count)
    {
        if (count > 0){
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, spawnVec + new Vector3(Random.Range(-1 * spawnDistance, spawnDistance), 
        Random.Range(-1 * spawnDistance, spawnDistance), 0) , Quaternion.identity);
        count--;
        StartCoroutine(spawnEnemy(interval, enemy, count));
        }
        
    }
}
