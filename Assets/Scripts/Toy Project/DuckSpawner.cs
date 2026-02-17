using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
    public GameObject duckPrefab;
    public GameObject spawnedDuck;
    public float timer;
    public float spawnDuration; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnDuration = Random.Range(3, 6);
        Vector2 randomLoco = (Vector2)transform.position + Random.insideUnitCircle; 
        timer += Time.deltaTime;  
        if (timer > spawnDuration)
        {
            spawnedDuck = Instantiate(duckPrefab, randomLoco, Quaternion.identity);
            timer = 0; 
        }
    }
}
