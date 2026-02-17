using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelPointer : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject spawnedBullet; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calculate direction of barrel in relation to mouse 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 direction = mousePos - (Vector2)transform.position;
        transform.up = direction;

        //if (Mouse.current.leftButton.wasPressedThisFrame)
        //{
        //    spawnedBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //}
    }
}
