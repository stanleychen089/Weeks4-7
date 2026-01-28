using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnerChallenge : MonoBehaviour
{
    public GameObject spawnObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            RandomSpawn();
        }
    }

    public void RandomSpawn()
    {
        Vector2 randomLoco = Random.insideUnitCircle * 5; 
        Instantiate(spawnObject, randomLoco, Quaternion.identity); 

    }

}


