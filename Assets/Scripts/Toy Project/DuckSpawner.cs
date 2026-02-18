using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;


public class DuckSpawner : MonoBehaviour
{
    public GameObject duckPrefab;
    public GameObject spawnedDuck;
    public GameObject playerTransform;
    public float timer;
    public float spawnDuration;

    public DuckMovement movementScript;

    //keep list of spawned things
    public List<GameObject> duckSpawns;

    void Start()
    {
        spawnDuration = Random.Range(3, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;  
        if (timer > spawnDuration)
        {
            Vector2 randomLoco = (Vector2)transform.position + Random.insideUnitCircle;
            spawnedDuck = Instantiate(duckPrefab, randomLoco, Quaternion.identity);

            //add spawnedDucks into list of duckSpawns
            duckSpawns.Add(spawnedDuck);

            //Need the spawned duck to getcomponent of the player's position 
            spawnedDuck.GetComponent<DuckMovement>().playerObject = playerTransform; 

            
            timer = 0;
            spawnDuration = Random.Range(3, 6);
        }
    }
}
