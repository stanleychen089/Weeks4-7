using UnityEngine;
using UnityEngine.InputSystem;

public class BulletMovement : MonoBehaviour
{
    public float speed = 7;
    public float timer = 0;
    public float destructionTime = 5; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //movement
        transform.position += transform.right * speed * Time.deltaTime;

        timer += Time.deltaTime;
        if (timer > destructionTime)
        {
            Destroy(gameObject);
            timer = 0;
        }
    }
}
