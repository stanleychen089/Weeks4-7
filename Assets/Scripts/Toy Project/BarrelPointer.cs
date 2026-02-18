using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelPointer : MonoBehaviour
{ 
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

    }
}
