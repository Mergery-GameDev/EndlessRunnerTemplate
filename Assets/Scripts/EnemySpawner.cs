using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Enemies")]
    public GameObject[] enemyObject;
    [SerializeField]
    private Vector3 enemySpawnPosition = new Vector3(3.0f, 0.5f, 24.6f);
    private int enemyObjectIndex;
    float enemyStartTime = 5.0f;
    float enemySpawnTime= 3.0f;

    [Header("Collectibles")]
    public GameObject[] collectiblesObject;
    [SerializeField]
    private Vector3 collectiblesSpawnPosition = new Vector3(3.0f, 0.5f, 24.6f);
    private int collectibleObjectIndex;
    float collectibleStartTime = 8.0f;
    float collectibleSpawnTime= 4.0f;

    


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnEnemies",enemyStartTime, enemySpawnTime);
        InvokeRepeating("SpawnCollectibles",collectibleStartTime, collectibleSpawnTime);

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnEnemies()
    {
        enemyObjectIndex = Random.Range(0, enemyObject.Length);
        enemySpawnPosition.x= Random.Range(-4.5f, 4.5f);

        Instantiate(enemyObject[enemyObjectIndex], enemySpawnPosition, enemyObject[enemyObjectIndex].transform.rotation);
    }

    public void SpawnCollectibles()
    {
        collectibleObjectIndex = Random.Range(0, collectiblesObject.Length);
        collectiblesSpawnPosition.x= Random.Range(-4.5f, 4.5f);
        collectiblesSpawnPosition.y = Random.Range(0.5f, 1.0f);

        Instantiate(collectiblesObject[collectibleObjectIndex], collectiblesSpawnPosition, collectiblesObject[collectibleObjectIndex].transform.rotation);
    }
    
}
