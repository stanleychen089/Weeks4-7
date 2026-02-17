using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTankMovement : MonoBehaviour
{
    public float speed = 4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            moveUp();
        }
        if (Keyboard.current.aKey.isPressed)
        {
            moveLeft();
        }
        if (Keyboard.current.sKey.isPressed)
        {
            moveDown();
        }
        if (Keyboard.current.dKey.isPressed)
        {
            moveRight();
        }
    }

    void moveUp()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
    void moveLeft()
    {
        transform.position -= transform.right * speed * Time.deltaTime;

    }
    void moveDown()
    {
        transform.position -= transform.up * speed * Time.deltaTime;

    }
    void moveRight()
    {
        transform.position += transform.right * speed * Time.deltaTime;

    }
}
