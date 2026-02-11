using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //direction
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 direction = MousePos - (Vector2)transform.position;
        transform.up = direction;


    }
}
