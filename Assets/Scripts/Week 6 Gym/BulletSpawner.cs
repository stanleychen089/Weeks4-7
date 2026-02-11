using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class BulletSpawner : MonoBehaviour
{
    //object references 
    public GameObject bulletPrefab;
    public GameObject spawnedBullet;

    //script reference
    public BulletMovement movementScript;

    //sound references
    public AudioSource audioSource;
    public AudioClip shotSound; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //spawns tank when mouse is clicked
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            spawnedBullet = Instantiate(bulletPrefab,transform.position, transform.rotation);
            audioSource.PlayOneShot(shotSound);
            movementScript = spawnedBullet.GetComponent<BulletMovement>();

        }


    }
}
