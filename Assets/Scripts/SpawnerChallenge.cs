using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnerChallenge : MonoBehaviour
{
    public GameObject spawnObject;
    public int objectCounter = 0;
    public GameObject spawnedObject; 

    public FirstScript movementScript;

    public List<GameObject> tanks;

    public Transform barrel;

    public GameObject duckiePrefab; 
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

           movementScript = spawnedObject.GetComponent<FirstScript>();

            objectCounter++;

           movementScript.speed = objectCounter;


            //list of spawned things 
            tanks.Add(spawnedObject);

            Instantiate(duckiePrefab, Random.insideUnitCircle*3, Quaternion.identity);
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            tanks.Remove(spawnedObject);
            Destroy(spawnedObject); 
        }

        //loop through the list of tanks, which are game objects 
        //get the tank's transform 
        //compare the objects' transform to the barrel and check if they are the same position 
        for (int i = tanks.Count -1; i >= 0; i--)
        {
            float distance = Vector2.Distance(tanks[i].transform.position, barrel.position);
            if (distance < 0.5f)
            {
                Debug.Log("Explode Tank" + i);
                
                //we want to delete the most recent gameObject, so i has to count backwards rather than from 0 
                //Because lists and arrays start from 0, the 5 item in the list is actually index 4
                //Meaning to count down, we must do list.Count -1; 
                GameObject destroyTank = tanks[i];

                tanks.Remove(destroyTank);
                Destroy(destroyTank);
            }
        }
    }

    public void RandomSpawn()
    {
        Vector2 randomLoco = Random.insideUnitCircle * 1; 
        spawnedObject = Instantiate(spawnObject, randomLoco, Quaternion.identity); 

    }

}


