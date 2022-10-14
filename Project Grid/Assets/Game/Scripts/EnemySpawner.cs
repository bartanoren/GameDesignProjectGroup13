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


    // Start is called before the first frame update
    void Start()
    {
        
       spawnVec = transform.position ;

        StartCoroutine(spawnEnemy(spawnerInterval, spawnerPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, spawnVec + new Vector3(Random.Range(-1 * spawnDistance, spawnDistance), Random.Range(-1 * spawnDistance, spawnDistance), 0) , Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }

}
